using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {

        //  GAME STATE VARIABLES

        private int playerScore = 0;          // Stores player's points
        private int computerScore = 0;        // Stores computer's points
        private int currentRound = 0;         // Tracks the current round number

        private int totalRounds = 5;          // Number of rounds for "Best Of"
        private int maxPoints = 10;           // Point limit to win the match
        private int timeLeft = 5;             // Countdown timer for each round

        private Point rockOriginalPos;        // Saves original Rock picture location
        private Point paperOriginalPos;       // Saves original Paper picture location
        private Point scissorsOriginalPos;    // Saves original Scissors picture location

        private Random rnd = new Random();    // Random number generator for computer choices

        // Sound players for win and loss sound effects
        private SoundPlayer winPlayer;
        private SoundPlayer losePlayer;

        // CONSTRUCTOR
        public Form1()
        {
            InitializeComponent(); // Builds the form components

            // Set initial label text
            labelPlayerScore.Text = "Player";
            labelComputerScore.Text = "Computer";
            labelRound.Text = "Round";
            labelCountdown.Text = "Time";
            labelRoundResult.Text = "";

            // Store original positions of image controls
            rockOriginalPos = pictureRock.Location;
            paperOriginalPos = picturePaper.Location;
            scissorsOriginalPos = pictureScissors.Location;

            // Load win/lose sound files into memory
            winPlayer = new SoundPlayer(Resources.kids_cheering);
            losePlayer = new SoundPlayer(Resources.kid_sobbing);
            winPlayer.Load();
            losePlayer.Load();

            // Apply hover effects to all picture buttons
            AddHoverEffect(pictureRock);
            AddHoverEffect(picturePaper);
            AddHoverEffect(pictureScissors);
        }

        //  STARTING A NEW MATCH
        //  Triggered when the Start button is clicked
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Read user-selected settings from numeric controls
            totalRounds = (int)numOddBestOf.Value;
            maxPoints = (int)numMaxPoints.Value;

            // Reset on-screen message
            labelRoundResult.Text = "";

            // Reset timer display
            timeLeft = 5;
            labelCountdown.Text = $"Time: {timeLeft}";
            labelCountdown.ForeColor = Color.Black;

            // Allow user to click choices
            pictureRock.Enabled = true;
            picturePaper.Enabled = true;
            pictureScissors.Enabled = true;

            // Disable start button so players can’t restart mid-game
            buttonStart.Enabled = false;

            // Start the countdown timer
            roundTimer.Start();
        }

        //  ROUND TIMER
        //  Counts down each second and handles automatic scoring        
        private void roundTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--; // Reduce remaining time
            labelCountdown.Text = $"Time: {timeLeft}";

            // Change text color and beep when time is almost out
            if (timeLeft <= 3)
            {
                labelCountdown.ForeColor = Color.Red;
                SystemSounds.Beep.Play();
            }

            // If time runs out, award a point to computer
            if (timeLeft <= 0)
            {
                roundTimer.Stop(); // Stop timer

                computerScore++; // Computer gets point
                labelComputerScore.Text = $"Computer: {computerScore}";

                labelRoundResult.Text = "TIME OUT! COMPUTER GETS A POINT";

                // Check if this ends the game
                CheckGameEnd(GetWinPlayer());
            }
        }


        //  PLAYER CHOICE LOGIC
        //  Handles the player's selection and determines round winner
        private async void PlayerMakesChoice(string playerChoice)
        {
            string[] choices = { "Rock", "Paper", "Scissors" }; // Computer options
            string computerChoice = choices[rnd.Next(choices.Length)]; // Random pick

            roundTimer.Stop(); // Stop timer once user clicks

            // Disable player choices during evaluation
            pictureRock.Enabled = false;
            picturePaper.Enabled = false;
            pictureScissors.Enabled = false;

            // If both choose same, it’s a tie
            if (playerChoice == computerChoice)
            {
                labelRoundResult.ForeColor = Color.Black;
                labelRoundResult.Text =
                    $"⚪ Player chose {playerChoice}, Computer chose {computerChoice}. It's a tie!";

                StartNextRound(); // Start new round automatically
                return;
            }

            // Determine if player wins using RPS rules
            bool playerWins =
                (playerChoice == "Rock" && computerChoice == "Scissors") ||
                (playerChoice == "Paper" && computerChoice == "Rock") ||
                (playerChoice == "Scissors" && computerChoice == "Paper");

            // Update UI based on winner
            if (playerWins)
            {
                playerScore++;
                labelPlayerScore.Text = $"Player: {playerScore}";
                labelRoundResult.ForeColor = Color.Green;
                labelRoundResult.Text = $"🟢 Player chose {playerChoice}, Computer chose {computerChoice}. Player wins!";
            }
            else
            {
                computerScore++;
                labelComputerScore.Text = $"Computer: {computerScore}";
                labelRoundResult.ForeColor = Color.Red;
                labelRoundResult.Text = $"🔴 Player chose {playerChoice}, Computer chose {computerChoice}. Computer wins!";
            }

            // Increase round count
            currentRound++;
            labelRound.Text = $"Round: {currentRound}";

            // Check if game has reached end condition
            bool gameEnded = await CheckGameEnd(GetWinPlayer());

            // Start another round only if match continues
            if (!gameEnded)
                StartNextRound();
        }

        //  MOVE TO NEXT ROUND
        //  Resets timers and re-enables choice buttons
        private void StartNextRound()
        {
            timeLeft = 5; // Reset timer
            labelCountdown.ForeColor = Color.Black;
            labelCountdown.Text = $"Time: {timeLeft}";

            // Re-enable choices for next round
            pictureRock.Enabled = true;
            picturePaper.Enabled = true;
            pictureScissors.Enabled = true;

            // Restart round timer
            roundTimer.Start();
        }

        //  RETRIEVE WIN SOUND
        private SoundPlayer GetWinPlayer() => winPlayer; // Simple getter method

        //  CHECK IF GAME IS OVER
        //  Evaluates scores and triggers win/lose animations
        private async Task<bool> CheckGameEnd(SoundPlayer winPlayer)
        {
            int firstToWin = (totalRounds / 2) + 1; // "Best Of" win threshold

            // Check if either ending condition is met
            bool scoreLimitReached = playerScore >= maxPoints || computerScore >= maxPoints;
            bool bestOfReached = playerScore >= firstToWin || computerScore >= firstToWin;

            // If neither condition met, continue game
            if (!scoreLimitReached && !bestOfReached)
                return false;

            string winnerMessage;

            // Determine winner and play animations/sounds
            if (playerScore > computerScore)
            {
                winnerMessage = "Player wins the game!";
                winPlayer.Play();
                PlayWinAnimation();
            }
            else
            {
                winnerMessage = "Computer wins the game!";
                losePlayer.Play();
                PlayLossAnimation();
            }

            await Task.Delay(500); // Small pause before popup

            // Show Game Over popup
            MessageBox.Show(winnerMessage, "Game Over");

            gifCelebration.Visible = false; // Hide animation
            ResetGame(); // Reset all state
            return true;
        }

        //  RESET GAME
        //  Returns all variables and UI to initial state
        private void ResetGame()
        {
            roundTimer.Stop(); // Stop timer

            // Disable choice buttons
            pictureRock.Enabled = false;
            picturePaper.Enabled = false;
            pictureScissors.Enabled = false;

            // Reset counters
            playerScore = 0;
            computerScore = 0;
            currentRound = 0;

            // Reset labels
            labelPlayerScore.Text = "Player: 0";
            labelComputerScore.Text = "Computer: 0";
            labelRound.Text = "Round: 0";
            labelRoundResult.Text = "";

            // Reset timer display
            timeLeft = 5;
            labelCountdown.Text = "Time: 5";
            labelCountdown.ForeColor = Color.Black;

            // Allow user to start new game
            buttonStart.Enabled = true;
        }

        //  UI EVENT HANDLERS
        //  Handle clicks on Rock/Paper/Scissors and Quit button

        private void pictureRock_Click(object sender, EventArgs e) => PlayerMakesChoice("Rock");
        private void picturePaper_Click(object sender, EventArgs e) => PlayerMakesChoice("Paper");
        private void pictureScissors_Click(object sender, EventArgs e) => PlayerMakesChoice("Scissors");

        private void buttonQuit_Click(object sender, EventArgs e) => Application.Exit(); // Quit app

        //  ADD HOVER EFFECT
        //  Highlights picture buttons on mouse over
        private void AddHoverEffect(PictureBox pic)
        {
            pic.MouseEnter += (s, e) =>
            {
                pic.BorderStyle = BorderStyle.FixedSingle; // Add border
                pic.Cursor = Cursors.Hand;                 // Change cursor
            };

            pic.MouseLeave += (s, e) =>
            {
                pic.BorderStyle = BorderStyle.None;        // Remove border
            };
        }

        //  PLAY GIF ANIMATIONS
        //  Displays a GIF for win/lose animations
        private async Task PlayGif(Image gif, int durationMs = 3000)
        {
            gifCelebration.Image = gif; // Show the GIF
            gifCelebration.Visible = true;
            gifCelebration.BringToFront(); // Make sure it's on top

            await Task.Delay(durationMs); // Keep GIF visible for duration

            gifCelebration.Visible = false; // Hide GIF
            gifCelebration.Image = null;    // Remove reference
        }

        //  OPEN README FILE
        //  Writes embedded README resource to temp and opens it
        private void btnReadme_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.Combine(Path.GetTempPath(), "README.docx"); // Build a temp file path
                File.WriteAllBytes(tempPath, Resources.README); // Write embedded file to disk

                // Open file using default associated application
                Process.Start(new ProcessStartInfo()
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Display an error popup if opening fails
                MessageBox.Show("Could not open README file.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  WIN / LOSE ANIMATIONS
        private async void PlayWinAnimation() => await PlayGif(Resources.sparkles, 3000); // Play win animation
        private async void PlayLossAnimation() => await PlayGif(Resources.lose, 3000);    // Play loss animation
    }
}
