using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemoryMatch1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Declaring and intializing variables
        // Initialize 12 cards equal to 0; two will equal 1, two will equal 2, etc through 6
        // assigned below in a randomization loop.
        // You can pick any order you want but here is an order
        // Values: 1= Kitten; 2= Puppy; 3= Monkey; 4= Polar bears; 5= Wile E Coyote; 6= Road Runner

        private int card1 = 0, card2 = 0, card3 = 0, card4 = 0, card5 = 0, card6 = 0, card7 = 0,
            card8 = 0, card9 = 0, card10 = 0, card11 = 0, card12 = 0;
        private int randomNum = 0;                  // used to randomly assign cards to images
        private int numMatches = 0;                 // counts the number of matches when randomizing
        private int counter = 0;                    // used inside the randomization as a counter
        private int mistakes = 0;                   // counts wrong attempts, displayed in the upper left
        private int numSelectedCards = 0;           // will either be 0, 1, 2
        private int totalNumMatchesRemoved = 0;     // will be 0, 1, 2, 3, 4, 5, 6
        private int firstSelectedCard = 0;          // set it equal to the match number 1-6 
        // below, store the first selected image control and border control
        // so that they can be compated against the second selection.
        private System.Windows.Controls.Image firstSelectedImage = new Image();
        private System.Windows.Controls.Border firstSelectedBorder = new Border();

        public MainWindow()
        {
            InitializeComponent();

            //set imageLoc and hide the 6 matches
            var uriSource = new Uri(@"cardPair_sm.png", UriKind.Relative);
            pbMatch1.Source = new BitmapImage(uriSource);
            pbMatch2.Source = new BitmapImage(uriSource);
            pbMatch3.Source = new BitmapImage(uriSource);
            pbMatch4.Source = new BitmapImage(uriSource);
            pbMatch5.Source = new BitmapImage(uriSource);
            pbMatch6.Source = new BitmapImage(uriSource);

            //call playGame to setup a new game
            playGame();

        }// end MainWindow
        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            playGame();
        }
        private void playGame()
        {
            // re-initializing variables
            card1 = 0;
            card2 = 0;
            card3 = 0;
            card4 = 0;
            card5 = 0;
            card6 = 0;
            card7 = 0;
            card8 = 0;
            card9 = 0;
            card10 = 0;
            card11 = 0;
            card12 = 0;
            randomNum = 0;
            numMatches = 0;
            counter = 0;
            mistakes = 0;
            numSelectedCards = 0;
            totalNumMatchesRemoved = 0;
            firstSelectedCard = 0;
            firstSelectedBorder = new Border();
            firstSelectedImage = new Image();

            //hide congrats and play again
            lblCongrats.Visibility = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Hidden;

            // Show all 12 Cards
            pbBorder1.Visibility = Visibility.Visible;
            pbBorder2.Visibility = Visibility.Visible;
            pbBorder3.Visibility = Visibility.Visible;
            pbBorder4.Visibility = Visibility.Visible;
            pbBorder5.Visibility = Visibility.Visible;
            pbBorder6.Visibility = Visibility.Visible;
            pbBorder7.Visibility = Visibility.Visible;
            pbBorder8.Visibility = Visibility.Visible;
            pbBorder9.Visibility = Visibility.Visible;
            pbBorder10.Visibility = Visibility.Visible;
            pbBorder11.Visibility = Visibility.Visible;
            pbBorder12.Visibility = Visibility.Visible;

            // Hide the matches in the top right
            pbMatch1.Visibility = Visibility.Hidden;
            pbMatch2.Visibility = Visibility.Hidden;
            pbMatch3.Visibility = Visibility.Hidden;
            pbMatch4.Visibility = Visibility.Hidden;
            pbMatch5.Visibility = Visibility.Hidden;
            pbMatch6.Visibility = Visibility.Hidden;

            // Show the card backs
            var uriSource = new Uri(@"cardBack.jpg", UriKind.Relative);
            pictureBox1.Source = new BitmapImage(uriSource);
            pictureBox2.Source = new BitmapImage(uriSource);
            pictureBox3.Source = new BitmapImage(uriSource);
            pictureBox4.Source = new BitmapImage(uriSource);
            pictureBox5.Source = new BitmapImage(uriSource);
            pictureBox6.Source = new BitmapImage(uriSource);
            pictureBox7.Source = new BitmapImage(uriSource);
            pictureBox8.Source = new BitmapImage(uriSource);
            pictureBox9.Source = new BitmapImage(uriSource);
            pictureBox10.Source = new BitmapImage(uriSource);
            pictureBox11.Source = new BitmapImage(uriSource);
            pictureBox12.Source = new BitmapImage(uriSource);

            //clear the mistakes label
            lblMistakes.Content = "";

            Random R = new Random();

            // We have 12 cards, so we need 6 matches. Loop until we have 6 matches
            while (numMatches < 6)
            {
                randomNum = R.Next(1, 13);

                switch (randomNum)
                {
                    case 1:
                        if (card1 == 0)
                        {
                            card1 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 2:
                        if (card2 == 0)
                        {
                            card2 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 3:
                        if (card3 == 0)
                        {
                            card3 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 4:
                        if (card4 == 0)
                        {
                            card4 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 5:
                        if (card5 == 0)
                        {
                            card5 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 6:
                        if (card6 == 0)
                        {
                            card6 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 7:
                        if (card7 == 0)
                        {
                            card7 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 8:
                        if (card8 == 0)
                        {
                            card8 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 9:
                        if (card9 == 0)
                        {
                            card9 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 10:
                        if (card10 == 0)
                        {
                            card10 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 11:
                        if (card11 == 0)
                        {
                            card11 = numMatches + 1;
                            counter++;
                        }
                        break;
                    case 12:
                        if (card12 == 0)
                        {
                            card12 = numMatches + 1;
                            counter++;
                        }
                        break;
                }// end switch

                if (counter == 2)
                {
                    numMatches++;
                    counter = 0;
                }
            }// end while loop

            //Cards are now matched up. When one is selected, a picture 
            // will be displayed based on the value of card through card 12.
            // 1 = kitten
            // 2 = puppy
            // 3 = monkey
            // 4 = polar bears
            // 5 = wile e coyote
            // 6 = road runner
        }// end play game
        private void displayMatches()
        {
            // use a for loop to display correct number of matches in corner
            for (int x = 1; x <= totalNumMatchesRemoved; x++)
            {
                switch (x)
                {
                    case 1:
                        pbMatch1.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        pbMatch2.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        pbMatch3.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        pbMatch4.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        pbMatch5.Visibility = Visibility.Visible;
                        break;
                    case 6:
                        pbMatch6.Visibility = Visibility.Visible;
                        break;
                }// end switch
            }// end for
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //create a new image control and its surrounding border
            System.Windows.Controls.Image currentImage = new Image();
            System.Windows.Controls.Border currentBorder = new Border();

            //cast the sender into an image control
            currentImage = (System.Windows.Controls.Image)sender;

            //increment numSelected card = will be 0, 1 or 2
            numSelectedCards++;

            // declare and initalize it to something, doesnt matter what it's intialized to 
            // just has to be initialized
            var uriSource = new Uri(@"kitten.jpg", UriKind.Relative);

            //create a variable to store the current card
            int currentCard = 0;

            // determine which card needs to be used based on which image was clicked
            // determine the surrounding border based on which image was clicked
            if (currentImage.Name == "pictureBox1")
            {
                currentCard = card1;
                currentBorder = pbBorder1;
            }
            else if (currentImage.Name == "pictureBox2")
            {
                currentCard = card2;
                currentBorder = pbBorder2;
            }
            else if (currentImage.Name == "pictureBox3")
            {
                currentCard = card3;
                currentBorder = pbBorder3;
            }
            else if (currentImage.Name == "pictureBox4")
            {
                currentCard = card4;
                currentBorder = pbBorder4;
            }
            else if (currentImage.Name == "pictureBox5")
            {
                currentCard = card5;
                currentBorder = pbBorder5;
            }
            else if (currentImage.Name == "pictureBox6")
            {
                currentCard = card6;
                currentBorder = pbBorder6;
            }
            else if (currentImage.Name == "pictureBox7")
            {
                currentCard = card7;
                currentBorder = pbBorder7;
            }
            else if (currentImage.Name == "pictureBox8")
            {
                currentCard = card8;
                currentBorder = pbBorder8;
            }
            else if (currentImage.Name == "pictureBox9")
            {
                currentCard = card9;
                currentBorder = pbBorder9;
            }
            else if (currentImage.Name == "pictureBox10")
            {
                currentCard = card10;
                currentBorder = pbBorder10;
            }
            else if (currentImage.Name == "pictureBox11")
            {
                currentCard = card11;
                currentBorder = pbBorder11;
            }
            else if (currentImage.Name == "pictureBox12")
            {
                currentCard = card12;
                currentBorder = pbBorder12;
            }

            // check to see which picture to display
            if (currentCard == 1)
                uriSource = new Uri(@"kitten.jpg", UriKind.Relative);
            else if (currentCard == 2)
                uriSource = new Uri(@"puppy.jpg", UriKind.Relative);
            else if (currentCard == 3)
                uriSource = new Uri(@"funnyMonkey.jpg", UriKind.Relative);
            else if (currentCard == 4)
                uriSource = new Uri(@"polarBears.jpg", UriKind.Relative);
            else if (currentCard == 5)
                uriSource = new Uri(@"WileECoyote.jpg", UriKind.Relative);
            else if (currentCard == 6)
                uriSource = new Uri(@"roadrunner.gif", UriKind.Relative);

            // put the new image source into currentImage that was clicked on
            currentImage.Source = new BitmapImage(uriSource);

            // check to see if two cards have been selected
            if (numSelectedCards == 2)
            {
                //pause the application
                // wpfApplication is a custom class. Must add the class to your solution to use it
                // wpf dpesn't have DoEvents, which is why you need the class
                System.Threading.Thread.Sleep(100);
                MemoryMatch.WpfApplication.DoEvents();
                System.Threading.Thread.Sleep(100);
                MemoryMatch.WpfApplication.DoEvents();
                System.Threading.Thread.Sleep(1200);
                MemoryMatch.WpfApplication.DoEvents();

                // check to see if the first card hat was selected is the same as the second
                if (firstSelectedCard == currentCard)
                {
                    //correct choice, first & second choices match, remove them from the screen
                    // set visibility of both cards to hidden
                    currentBorder.Visibility = Visibility.Hidden;
                    firstSelectedBorder.Visibility = Visibility.Hidden;

                    // increment totalNumMatchesRemoved
                    totalNumMatchesRemoved++;

                    //display the number of matches in upper right corner
                    displayMatches();

                    //check to see if all matches have been removed
                    if (totalNumMatchesRemoved == 6)
                    {
                        //show confgrats! and play again button
                        lblCongrats.Visibility = Visibility.Visible;
                        btnPlayAgain.Visibility = Visibility.Visible;
                    }// end show congrats
                }
                else
                {
                    // wrong choice, first and second choices don't match, turn the cards back over

                    //wrong choice, increment mistakes
                    mistakes++;
                    lblMistakes.Content = mistakes.ToString();

                    //set the UriSource back equal to the cardback
                    uriSource = new Uri(@"cardBack.jpg", UriKind.Relative);

                    //assign the cardBakc to all the image controls
                    pictureBox1.Source  = new BitmapImage(uriSource);
                    pictureBox2.Source  = new BitmapImage(uriSource);
                    pictureBox3.Source  = new BitmapImage(uriSource);
                    pictureBox4.Source  = new BitmapImage(uriSource);
                    pictureBox5.Source  = new BitmapImage(uriSource);
                    pictureBox6.Source  = new BitmapImage(uriSource);
                    pictureBox7.Source  = new BitmapImage(uriSource);
                    pictureBox8.Source  = new BitmapImage(uriSource);
                    pictureBox9.Source  = new BitmapImage(uriSource);
                    pictureBox10.Source = new BitmapImage(uriSource);
                    pictureBox11.Source = new BitmapImage(uriSource);
                    pictureBox12.Source = new BitmapImage(uriSource);
                }// end firstSelectedCard if

                // reset the number of selected cards to 0 because we
                // either just turned them all over or removed them.
                numSelectedCards    = 0;
                firstSelectedCard   = 0;
                firstSelectedBorder = new Border();
                firstSelectedImage  = new Image();
            }
            else if (firstSelectedCard == 0)
            {
                //set the first selected card, image, border so we can access it later
                firstSelectedCard = currentCard;
                firstSelectedImage = currentImage;
                firstSelectedBorder = currentBorder;
            }// end if...else
        }// end pictureBox_Click
    } // end class
}// end namespace
