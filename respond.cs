using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberChatBotGUI
{
    public class respond
    {
        private ArrayList responseList;
        private ArrayList ignoreList;

        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor
            responseList = reply;
            ignoreList = ignore;
            answers(reply);
            words(ignore);
        }//end of constructor

        // NEW METHOD: Gets a response based on user input
        public string getResponse(string userInput)
        {
            string lowerInput = userInput.ToLower();

            // Remove ignore words from input
            string cleanInput = RemoveIgnoreWords(lowerInput);

            // Check for keywords in the clean input
            foreach (string response in responseList)
            {
                string responseLower = response.ToString().ToLower();

                // Check if this response has a keyword prefix (e.g., "greeting", "password", etc.)
                foreach (string keyword in GetKeywords())
                {
                    if (responseLower.StartsWith(keyword + " "))
                    {
                        // Check if user input contains this keyword
                        if (cleanInput.Contains(keyword) || lowerInput.Contains(keyword))
                        {
                            // Return the response without the keyword prefix
                            return response.ToString().Substring(keyword.Length + 1);
                        }
                    }
                }
            }

            // Default response if no keyword matched
            return "I'm not sure I understand. Can you please rephrase your question? You can ask me about passwords, phishing, cybersecurity, or online safety.";
        }

        // Helper method to remove ignore words from input
        private string RemoveIgnoreWords(string input)
        {
            string result = input;
            foreach (string word in ignoreList)
            {
                string wordLower = word.ToString().ToLower();
                result = result.Replace(" " + wordLower + " ", " ");
                result = result.Replace(wordLower + " ", " ");
                result = result.Replace(" " + wordLower, " ");
            }
            return result;
        }

        // Helper method to get all keywords from stored responses
        private ArrayList GetKeywords()
        {
            ArrayList keywords = new ArrayList();
            keywords.Add("greeting");
            keywords.Add("purpose");
            keywords.Add("cybersecurity");
            keywords.Add("phishing");
            keywords.Add("firewall");
            keywords.Add("password");
            keywords.Add("hacked");
            keywords.Add("fraud");
            keywords.Add("malicious");
            keywords.Add("vpn");
            keywords.Add("frustrated");
            keywords.Add("confused");
            keywords.Add("worried");
            keywords.Add("happy");
            keywords.Add("sad");
            keywords.Add("angry");
            keywords.Add("scam");
            keywords.Add("privacy");
            keywords.Add("2fa");
            keywords.Add("update");
            return keywords;
        }

        //method to store the list of words to ignore
        private void words(ArrayList ignoring)
        {
            // ========== ORIGINAL IGNORE WORDS ==========
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

            // additional ignore words
            ignoring.Add("what");
            ignoring.Add("when");
            ignoring.Add("where");
            ignoring.Add("which");
            ignoring.Add("who");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("how");
            ignoring.Add("tell");
            ignoring.Add("told");
            ignoring.Add("says");
            ignoring.Add("said");
            ignoring.Add("think");
            ignoring.Add("thought");
            ignoring.Add("know");
            ignoring.Add("knew");
            ignoring.Add("want");
            ignoring.Add("wanted");
            ignoring.Add("need");
            ignoring.Add("needed");
            ignoring.Add("help");
            ignoring.Add("helped");
            ignoring.Add("explain");
            ignoring.Add("explained");
            ignoring.Add("please");
            ignoring.Add("just");
            ignoring.Add("like");
            ignoring.Add("uh");
            ignoring.Add("um");
            ignoring.Add("hmm");
        }

        public void answers(ArrayList add_answers)
        {
            // greeting responses
            add_answers.Add("greeting hello there! i'm doing fantastic today. how are you doing?");
            add_answers.Add("greeting hey! i'm doing really well, thanks for asking! what can i help you with today?");
            add_answers.Add("greeting greetings! i'm feeling great and ready to help. how's your day going so far?");
            add_answers.Add("greeting i'm doing awesome, thank you for asking! is there anything cybersecurity-related i can assist you with?");
            add_answers.Add("greeting hello! i'm in good spirits today. what brings you to the cybersecurity awareness bot?");

            // purpose responses
            add_answers.Add("purpose my main goal is to educate you about online safety and help you navigate cybersecurity questions with confidence.");
            add_answers.Add("purpose i'm here to help you understand digital protection and stay safe from online threats.");
            add_answers.Add("purpose my job is to assist you with cybersecurity awareness, from password safety to spotting phishing attempts.");
            add_answers.Add("purpose i exist to guide you through the world of online security and make complex topics easy to understand.");
            add_answers.Add("purpose think of me as your personal cybersecurity assistant - i'm here to answer your questions and keep you informed.");

            // cybersecurity responses
            add_answers.Add("cybersecurity cybersecurity is the practice of protecting computers, servers, networks, and data from digital attacks.");
            add_answers.Add("cybersecurity it's all about keeping your online accounts, personal information, and devices safe from hackers.");
            add_answers.Add("cybersecurity this field focuses on defending systems against unauthorized access and cyber threats.");
            add_answers.Add("cybersecurity think of it as digital security - it protects everything from your social media to your bank accounts.");
            add_answers.Add("cybersecurity it involves using tools and best practices to ensure your online presence remains private and secure.");

            // phishing responses
            add_answers.Add("phishing phishing is when scammers impersonate legitimate companies to steal your personal information.");
            add_answers.Add("phishing it's a common trick where attackers send fake emails or texts that look real to get your passwords.");
            add_answers.Add("phishing these attacks often create a sense of urgency, like saying your account will be closed unless you act now.");
            add_answers.Add("phishing always check email addresses carefully - scammers use addresses that look almost identical to real ones.");
            add_answers.Add("phishing never click on suspicious links or download attachments from unknown senders, no matter how convincing they seem.");

            // firewall responses
            add_answers.Add("firewall a firewall acts as a security guard for your network, deciding what traffic can enter and leave.");
            add_answers.Add("firewall it monitors incoming and outgoing traffic based on pre-established security rules.");
            add_answers.Add("firewall think of it as a barrier that keeps unwanted visitors out of your system.");
            add_answers.Add("firewall both Windows and Mac computers come with built-in firewalls that you should keep enabled.");
            add_answers.Add("firewall having a properly configured firewall is one of the first lines of defense against cyber attacks.");

            // password responses
            add_answers.Add("password a strong password should be at least 12 characters long with a mix of letters, numbers, and symbols.");
            add_answers.Add("password never reuse passwords across different accounts - each one needs its own unique password.");
            add_answers.Add("password avoid using personal information like birthdays, pet names, or addresses in your passwords.");
            add_answers.Add("password consider using a password manager to generate and store complex passwords securely.");
            add_answers.Add("password enable two-factor authentication whenever possible for an extra layer of protection.");

            // hacked account responses
            add_answers.Add("hacked first, change your password immediately and log out of all connected devices.");
            add_answers.Add("hacked contact the platform's support team right away to report the unauthorized access.");
            add_answers.Add("hacked enable two-factor authentication after regaining access to prevent future breaches.");
            add_answers.Add("hacked check your account settings for any changes the hacker might have made.");
            add_answers.Add("hacked notify your contacts that your account was compromised so they don't open suspicious messages from you.");

            // fraud responses
            add_answers.Add("fraud if you suspect fraud, contact your bank or credit card company immediately to freeze your accounts.");
            add_answers.Add("fraud report the incident to your local authorities and file a complaint with the FTC.");
            add_answers.Add("fraud monitor your credit reports and bank statements regularly for any unauthorized transactions.");
            add_answers.Add("fraud place a fraud alert on your credit file to make it harder for criminals to open accounts in your name.");
            add_answers.Add("fraud keep all documentation related to the fraud - it will help with investigations and disputes.");

            // malicious chatbot responses
            add_answers.Add("malicious be wary of chatbots that ask for sensitive information like passwords or credit card numbers.");
            add_answers.Add("malicious legitimate bots will never pressure you to act immediately or threaten account closure.");
            add_answers.Add("malicious if a bot seems pushy or asks for personal data, stop interacting immediately.");
            add_answers.Add("malicious always verify you're on the official website before chatting with customer support.");
            add_answers.Add("malicious report suspicious chatbots to the platform where you encountered them.");

            // vpn responses
            add_answers.Add("vpn a vpn encrypts your internet connection, making it much harder for others to spy on your online activity.");
            add_answers.Add("vpn it's especially important to use a vpn when connecting to public wi-fi networks like coffee shops or airports.");
            add_answers.Add("vpn vpns also help protect your privacy by hiding your real IP address from websites you visit.");
            add_answers.Add("vpn choose a reputable vpn provider that doesn't keep logs of your browsing activity.");
            add_answers.Add("vpn while vpns improve security, they're not a complete solution - you still need strong passwords and antivirus software.");

            // scam responses
            add_answers.Add("scam online scams are designed to trick you into giving away money or personal information. always be skeptical of unexpected offers.");
            add_answers.Add("scam if something sounds too good to be true, it probably is - that's the golden rule of avoiding scams.");
            add_answers.Add("scam scammers often create fake urgency to make you act without thinking. always take a moment to verify before responding.");

            // privacy responses
            add_answers.Add("privacy protecting your privacy means controlling who has access to your personal information online.");
            add_answers.Add("privacy review your social media privacy settings regularly to ensure you're only sharing with people you trust.");
            add_answers.Add("privacy limit what personal details you share online - once information is out there, it's very hard to remove.");

            // 2fa responses
            add_answers.Add("2fa two-factor authentication adds an extra layer of security by requiring a second form of verification beyond your password.");
            add_answers.Add("2fa enable 2fa on all accounts that offer it - it's one of the most effective ways to prevent unauthorized access.");
            add_answers.Add("2fa with 2fa enabled, even if someone steals your password, they still can't access your account without the second factor.");

            // update responses
            add_answers.Add("update always keep your operating system, browser, and apps updated to protect against known security vulnerabilities.");
            add_answers.Add("update software updates often include important security patches that fix holes hackers could exploit.");
            add_answers.Add("update enable automatic updates whenever possible so you never miss critical security fixes.");

            // sentiment - frustrated
            add_answers.Add("frustrated i completely understand your frustration. let's work through this together, one step at a time.");
            add_answers.Add("frustrated it's totally normal to feel frustrated when dealing with security issues. i'm here to make this easier for you.");
            add_answers.Add("frustrated take a deep breath - we'll figure this out. can you tell me more about what's bothering you?");

            // sentiment - confused
            add_answers.Add("confused that's completely okay - cybersecurity can be confusing at first. let me explain it in simpler terms.");
            add_answers.Add("confused no worries at all! i'll walk you through this slowly so everything makes sense.");
            add_answers.Add("confused i appreciate you asking for clarification. let me rephrase that to help you understand better.");

            // sentiment - worried
            add_answers.Add("worried it's completely understandable to feel worried about online safety. let me share some reassuring tips with you.");
            add_answers.Add("worried i understand your concern. most security issues can be resolved quickly when you know what to do.");
            add_answers.Add("worried feeling worried is natural, but knowledge is power. let me give you some practical advice to help you feel safer.");

            // sentiment - happy
            add_answers.Add("happy that's wonderful to hear! positivity makes learning about security so much easier.");
            add_answers.Add("happy awesome! i'm glad things are going well for you. is there anything i can help you learn today?");
            add_answers.Add("happy fantastic! your good mood is contagious. what cybersecurity topic interests you today?");

            // sentiment - sad
            add_answers.Add("sad i'm really sorry you're feeling this way. i'm here for you, and we can take things at your pace.");
            add_answers.Add("sad that sounds really tough. remember that security issues can be fixed - you're not alone in this.");
            add_answers.Add("sad i'm here to help however i can. let me know what's bothering you.");

            // sentiment - angry
            add_answers.Add("angry i can see you're really upset about this, and that's valid. let's work on fixing the problem together.");
            add_answers.Add("angry i understand your anger - security issues can be incredibly frustrating. i'm here to help you resolve this.");
            add_answers.Add("angry i hear your frustration and anger. let's channel that energy into finding a solution together.");
        }
    }
}