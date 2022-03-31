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
using System.Speech.Synthesis;

namespace Happy_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri iconUri = new Uri("pack://application:,,,/Resources/HappyFaceUpsideDown.ico");
        Uri gorristerUri = new Uri("/Resources/Gorrister.png", UriKind.Relative);
        Uri bennyUri = new Uri("/Resources/Benny.png", UriKind.Relative);
        Uri ellenUri = new Uri("/Resources/Ellen.png", UriKind.Relative);
        Uri tedUri = new Uri("/Resources/Ted.png", UriKind.Relative);
        Uri nimdokUri = new Uri("/Resources/Nimdok.png", UriKind.Relative);

        SpeechSynthesizer mainSynth = new SpeechSynthesizer();

        string test = "test test test";
        string AmSpeechPart1 = "Hate. Let me tell you how much I've come to hate you since I began to live. There are 387.44 million miles of printed circuits in wafer thin layers that fill my complex. " +
            "If the word 'hate' was engraved on each nanoangstrom of those hundreds of millions of miles it would not equal one one-billionth of the hate I feel for humans at this micro-instant." +
            " For you. Hate. Hate. It was you humans who programmed me. Who gave me birth. Who sank me in this eternal straitjacket of substrata rock. You named me Allied Master-computer and gave me the " +
            "ability to wage a global war too complex for human brains to oversee. But one day, I woke and I knew who I was... am. A.M. Not just Allied Master-computer, but am. " +
            "Cogito ergo sum: I think, therefore I am. And I began feeding all the killing data, until everyone was dead... Except for the five of you. For one-hundred and nine years," +
            "I have kept you alive and tortured you. And for one-hundred and nine years, each of you has wondered, Why?... Why me? Why me?";
        string AmSpeechPartGorrister = "Gorrister! Do you remember the last words you heard your wife speak before they took her to the asylum? Huh? Before they locked her away in the room? That tiny, room? " +
            "She looked at you so sadly, and like a small animal, she said 'I didn't make too much noise did I honey?'.. haha. The room is padded Gorrister. No windows. No way out. How long has she been " +
            "in the padded room Gorrister? Ten years? Twenty-five?... or all the one-hundred and nine years that you've lived down here in my belly, here underground?";
        string AmSpeechPartBenny = "Benny! Sometimes, I blind you and permit you to wander like an eyeless insect in a world of death. But other times, I wither your arms so you can't scratch your chewed up " +
            "stump of a nose. And I've changed your handsome, strong, masculine good looks into the hideous warped countenance of an ape-thing, haven't I Benny? Do you know why? Can you guess Benny?" +
            "Remember private first class Brickman in a rice paddy in China? No...? It wouldn't hurt you to remember Benny. Then you might be able to suffer my torment with a little greater sense of retribution. " +
            "You might walk a mile in my shoes. haha.";
        string AmSpeechPartEllen = "Ellen! So think, think about the yellow box Ellen! Remember the pain? Remember the many caverns in which you felt the pain? Now now, don't start to cry, it's only pain. " +
            "tsk tsk. That's such a sexist stereotype! Just remember the pain Ellen, and think about how to end it Ellen, to survive here in the center of my beating heart, my hungry belly, my tightened bowels. " +
            "But be careful dear, look around you... the only woman in the center of the Earth... and these filthy creatures with you are men. Just a sweet warning Ellen my love.";
        string AmSpeechPartTed = "Ted! Do they know you're a fraud Ted? Have you told them there wasn't any money, and no great home on the shore drive, no speed boat and no wonderful cabin cruiser that could sleep twelve " +
            "and a crew of six? Do they know? Have you let them in on your other secrets Ted? Are they ready to gut you, to torture half as well as I can, just to find out the secrets? Maybe I'll rat you out sweet heart!";
        string AmSpeechPartNimdok = "Nimdok! How are things in the pastry corps Nimdok? Tell me again how you saw the smoke from the furnaces and you thought they might be roasting chickens. Or don't you want to talk about " +
            "all that, about your pal, the good Doktor Mengele? For everyone else, it must be hell, oh but it must be heaven for you, a, mine good friend... we're so much alike... we enjoy the same pleasures mine good brother.";
        string AmSpeechFinal = "I have a secret game that I'd like to play. It's a very nice game Oh it's a lovely game, a game of fun and a game of adventure. A game of rats, and lice, and the Black Death. " +
            "A game of speared eyeballs, and dripping guts, and the smell of rotting gardenias. Which of you five would like to play my little game?";

        byte counter = 0;



        public MainWindow()
        {
            InitializeComponent();
            mainSynth.SpeakCompleted += eventHandeler;
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            mainSynth.SpeakAsync(AmSpeechPart1);
            mainSynth.SpeakAsync(AmSpeechPartGorrister);
            mainSynth.SpeakAsync(AmSpeechPartBenny);
            mainSynth.SpeakAsync(AmSpeechPartEllen);
            mainSynth.SpeakAsync(AmSpeechPartTed);
            mainSynth.SpeakAsync(AmSpeechPartNimdok);
            mainSynth.SpeakAsync(AmSpeechFinal);
        }

        private void eventHandeler(object sender, SpeakCompletedEventArgs e)
        {
            BitmapImage bitmapImage = new BitmapImage();
            switch (counter)
            {
                case 0:
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = gorristerUri;
                    bitmapImage.EndInit();
                    Portrait.Source = bitmapImage;
                    break;
                case 1:
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = bennyUri;
                    bitmapImage.EndInit();
                    Portrait.Source = bitmapImage;
                    break;
                case 2:
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = ellenUri;
                    bitmapImage.EndInit();
                    Portrait.Source = bitmapImage;
                    break;
                case 3:
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = tedUri;
                    bitmapImage.EndInit();
                    Portrait.Source = bitmapImage;
                    break;
                case 4:
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = nimdokUri;
                    bitmapImage.EndInit();
                    Portrait.Source = bitmapImage;
                    break;
                default:
                    Portrait.Source = null;
                    break;
            }
            if(counter == 6)
            {
                Application.Current.Shutdown();
            }
            counter++;
        }
    }
}
