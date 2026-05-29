using System;
using System.Collections.Generic;

namespace CyberBotPart2
{
    public class Chatbot
    {
        private string userName;
        private string userInterest;
        private Dictionary<string, List<string>> responses;
        private Random random;

        public Chatbot()
        {
            random = new Random();

            responses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
            {
                // ========== PASSWORD SAFETY (Detailed) ==========
                { "password", new List<string> {
                    "🔐 **PASSWORD SAFETY TIPS:**\n• Use at least 12-16 characters\n• Include uppercase, lowercase, numbers AND symbols\n• Never reuse passwords across different websites\n• Change passwords every 3-6 months\n• Use a password manager like Bitwarden or LastPass\n• Avoid using personal info (birthdates, pet names, etc.)\n• Example of strong password: S@uth4fr1c@R0cks!2024",

                    "✅ **HOW TO CREATE STRONG PASSWORDS:**\n1. Use a phrase: 'My cat eats 2 pizzas!'\n2. Add numbers and symbols: 'MyC@tE@ts2Pizz@s!'\n3. Make it at least 12 characters long\n4. Never write passwords on sticky notes\n5. Enable Two-Factor Authentication (2FA) for extra security",

                    "⚠️ **PASSWORD DON'TS:**\n• Don't use 'password123' or 'admin'\n• Don't use your name or birthdate\n• Don't share passwords via email or SMS\n• Don't save passwords on public computers\n• Don't use the same password for banking and social media",

                    "🛡️ **SOUTH AFRICA STATS:** Over 60% of cyber attacks in SA happen due to weak passwords. A strong password can prevent 80% of hacking attempts!"
                }},
                
                // ========== PHISHING (Detailed) ==========
                { "phishing", new List<string> {
                    "🎣 **WHAT IS PHISHING?**\nPhishing is when scammers send fake emails, SMS, or WhatsApp messages pretending to be from legitimate companies (banks, SARS, MTN, Vodacom). Their goal is to steal your passwords, credit card details, or OTPs.\n\n**RED FLAGS TO WATCH:**\n• Urgent language: 'Your account will be closed!'\n• Spelling and grammar mistakes\n• Suspicious links (hover to check URL)\n• Requests for personal information\n• Too-good-to-be-true offers",

                    "📧 **HOW TO SPOT PHISHING EMAILS:**\n1. Check sender's email address carefully (info@paypal.com vs info@paypa1.com)\n2. Don't click links - type the website URL yourself\n3. Look for poor grammar and spelling errors\n4. Never download attachments from unknown senders\n5. Legitimate companies never ask for passwords via email\n\n**EXAMPLE:** 'Your Netflix account has been suspended. Click here to verify payment.' - This is 100% a scam!",

                    "🚨 **WHAT TO DO IF YOU RECEIVE A PHISHING EMAIL:**\n1. DO NOT click any links or download attachments\n2. Report it to the company being impersonated\n3. Forward suspicious emails to report@phishing.org.za\n4. Delete the email immediately\n5. If you clicked a link, change your passwords immediately\n6. Run a virus scan on your computer",

                    "📱 **WHATSAPP PHISHING (SMISHING):**\nScammers send fake WhatsApp messages claiming:\n• 'You won a MTN/Vodacom prize'\n• 'Your bank account is frozen'\n• 'Click here to verify your number'\n\n**NEVER** click links in unsolicited WhatsApp messages!"
                }},
                
                // ========== SCAMS (Detailed - South Africa Focused) ==========
                { "scam", new List<string> {
                    "⚠️ **COMMON SOUTH AFRICAN SCAMS:**\n\n**1. BANK SCAMS (Vishing):**\n• Scammer calls claiming to be from your bank\n• Says your account is compromised\n• Asks for OTP or PIN\n• Real banks NEVER ask for OTPs!\n\n**2. LOTTERY SCAMS:**\n• 'You won R50,000 in the UK Lottery!'\n• Need to pay 'fees' first\n• If you didn't enter, you didn't win\n\n**3. 'HELLO MUM' SCAM:**\n• WhatsApp: 'Mum, I lost my phone. This is my new number. Please send money.'\n• Always verify by calling the original number\n\n**4. SARS TAX SCAMS:**\n• Fake SMS/email: 'You owe SARS R10,000'\n• Never pay via unknown links\n• Check eFiling directly",

                    "📞 **HOW TO PROTECT YOURSELF FROM SCAMS:**\n• Never share OTPs, PINs, or passwords over phone\n• Hang up and call the company back on official number\n• If it sounds too good to be true, it's a scam\n• Don't rush - scammers create urgency\n• Report scams to SAPS or SAFPS (Southern African Fraud Prevention Service)\n• Save scam numbers to block them\n\n**EMERGENCY CONTACT:**\n• SAPS Crime Stop: 08600 10111\n• SAFPS: 011 867 2234",

                    "💰 **IF YOU'VE BEEN SCAMMED:**\n1. Contact your bank immediately to freeze accounts\n2. Change all passwords\n3. Report to SAPS (get case number)\n4. Report to SAFPS to protect your credit profile\n5. Warn family and friends\n\nSouth Africa lost over R5 billion to scams in 2024 - don't become a statistic!"
                }},
                
                // ========== PRIVACY (Detailed) ==========
                { "privacy", new List<string> {
                    "🔏 **ONLINE PRIVACY CHECKLIST:**\n\n**SOCIAL MEDIA:**\n• Set profiles to Private\n• Don't share your birthdate, address, or ID number\n• Remove location tags from posts\n• Review tagged photos before they appear\n• Remove old posts with personal info\n\n**PHONE PRIVACY:**\n• Review app permissions (Settings > Apps)\n• Remove access to contacts, camera, location if not needed\n• Use biometric locks (fingerprint/face ID)\n• Enable 'Find My Device'\n\n**BROWSING PRIVACY:**\n• Use a VPN on public Wi-Fi\n• Clear cookies and cache regularly\n• Use private/incognito mode\n• Install privacy extensions (Privacy Badger, uBlock Origin)",

                    "👁️ **WHAT SCAMMERS DO WITH YOUR INFORMATION:**\n• Identity theft (open accounts in your name)\n• Targeted phishing attacks\n• Social engineering (pretending to know you)\n• Account takeover\n\n**NEVER POST ONLINE:**\n• Your ID number\n• Bank account details\n• Your home address\n• Your birthday (use fake one)\n• Photos of your ID/passport\n• Your location in real-time",

                    "📱 **PRIVACY SETTINGS TO CHECK TODAY:**\n• Facebook: Settings > Privacy Checkup\n• Instagram: Settings > Privacy\n• WhatsApp: Settings > Privacy\n• Google: myaccount.google.com/privacy\n• TikTok: Settings > Privacy"
                }},
                
                // ========== SAFE BROWSING (Detailed) ==========
                { "safe browsing", new List<string> {
                    "🌐 **SAFE BROWSING TIPS:**\n\n**BEFORE CLICKING:**\n• Check for 'https://' (the 's' means secure)\n• Look for padlock icon in address bar\n• Verify website URL is correct (paypa1.com is fake)\n• Don't click pop-up ads\n\n**WHAT TO AVOID:**\n• Free movie streaming sites\n• 'Click here for free data' offers\n• Downloading software from unknown sources\n• Torrent websites\n\n**BROWSER EXTENSIONS TO USE:**\n• uBlock Origin (blocks malicious ads)\n• HTTPS Everywhere (forces secure connections)\n• Privacy Badger (blocks trackers)",

                    "🛡️ **PUBLIC WI-FI DANGERS:**\n• Mall, airport, coffee shop Wi-Fi is NOT secure\n• Hackers can intercept your data\n• Never do banking on public Wi-Fi\n• Use a VPN (ProtonVPN free version is good)\n• Turn off 'auto-connect' to Wi-Fi\n\n**SAFE ALTERNATIVES:**\n• Use your mobile data (4G/5G is more secure)\n• Wait until you're home\n• Use a personal hotspot",

                    "🔒 **BROWSER SECURITY SETTINGS:**\n• Enable 'Do Not Track'\n• Block third-party cookies\n• Turn on 'Safe Browsing' in Chrome/Edge\n• Disable automatic downloads\n• Clear browsing data monthly"
                }},
                
                // ========== TWO-FACTOR AUTHENTICATION (2FA) ==========
                { "2fa", new List<string> {
                    "📱 **WHAT IS TWO-FACTOR AUTHENTICATION (2FA)?**\n\n2FA adds an EXTRA layer of security beyond just your password. Even if a hacker steals your password, they CANNOT access your account without the second factor.\n\n**TYPES OF 2FA:**\n1. SMS code (less secure)\n2. Authenticator app (Google/Microsoft Authenticator) - BEST\n3. Hardware key (YubiKey)\n4. Biometrics (fingerprint/face ID)\n\n**WHICH ACCOUNTS NEED 2FA?**\n• Email (most important!)\n• Banking apps\n• Social media\n• Cloud storage (Google Drive, iCloud)\n• Password managers",

                    "✅ **HOW TO ENABLE 2FA:**\n1. Go to account settings\n2. Find 'Security' or 'Two-Factor Authentication'\n3. Choose 'Authenticator App' (not SMS if possible)\n4. Scan QR code with Google Authenticator\n5. Save backup codes somewhere safe!\n\n**APPS TO DOWNLOAD:**\n• Google Authenticator (free)\n• Microsoft Authenticator (free)\n• Authy (free, has cloud backup)",

                    "⚠️ **2FA WARNINGS:**\n• Never share 2FA codes with anyone\n• Save backup codes (print them)\n• If you lose your phone, you'll need backup codes\n• SMS 2FA can be intercepted - use authenticator app\n• South African banks now require 2FA - use it!"
                }},
                
                // ========== SOCIAL ENGINEERING ==========
                { "social engineering", new List<string> {
                    "🧠 **WHAT IS SOCIAL ENGINEERING?**\n\nSocial engineering is MANIPULATION - scammers trick you into giving information or access instead of hacking technology.\n\n**COMMON TACTICS:**\n• PRETEXTING: Fake scenario ('I'm from IT support')\n• BAITING: Free USB drive or download\n• TAILGATING: Following you into secure areas\n• QUID PRO QUO: 'Free service' for your info\n\n**REAL EXAMPLE:**\nScammer calls: 'Hi, I'm from Microsoft. Your computer has a virus. Let me remote in to fix it.' - This is 100% a scam!",

                    "🛡️ **HOW TO PROTECT YOURSELF:**\n• Never give passwords over phone\n• Verify caller by calling back on official number\n• Don't let strangers follow you into buildings\n• Be suspicious of unsolicited help\n• If it feels wrong, hang up\n\n**REMEMBER:** Trust your gut. If something feels off, it probably is!"
                }},
                
                // ========== HELP ==========
                { "help", new List<string> {
                    "📚 **CYBERSECURITY TOPICS I CAN HELP WITH:**\n\n🔐 **password** - Strong password tips\n🎣 **phishing** - Spot fake emails/SMS\n⚠️ **scam** - South African scams explained\n🔏 **privacy** - Protect your personal info\n🌐 **safe browsing** - Browse safely online\n📱 **2fa** - Two-Factor Authentication guide\n🧠 **social engineering** - Manipulation tactics\n\n**CONVERSATION COMMANDS:**\n• 'tell me more' - Get another tip\n• 'exit' - Close the chatbot\n\n**SOUTH AFRICA RESOURCES:**\n• SAFPS: 011 867 2234\n• SAPS Crime Stop: 08600 10111\n• Report phishing: report@phishing.org.za",

                    "💡 **TRY ASKING:**\n'Tell me about password safety'\n'How do I spot phishing?'\n'What scams happen in South Africa?'\n'How do I protect my privacy online?'\n'Explain 2FA to me'"
                }},
                
                // ========== GREETINGS ==========
                { "how are you", new List<string> {
                    "I'm functioning perfectly! Ready to help you learn about cybersecurity in South Africa! 🔐",
                    "Doing great! What would you like to learn about today?",
                    "All systems secure! Ask me about passwords, phishing, or scams!"
                }},

                { "purpose", new List<string> {
                    "I'm here to educate South Africans about cybersecurity threats. Scams, phishing, and hacking are increasing in SA - I want to help you stay safe online!",
                    "My mission is to help you recognize cyber threats before they harm you. Knowledge is your best defense!"
                }}
            };
        }

        public void SetUserName(string name)
        {
            userName = name;
        }

        public string GetUserInterest()
        {
            return userInterest;
        }

        public string GetResponse(string userInput)
        {
            string input = userInput.ToLower();

            // Check for keywords
            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    userInterest = keyword;
                    string response = GetRandomResponse(keyword);

                    // Personalize response with user's name
                    if (!string.IsNullOrEmpty(userName) && !response.Contains(userName))
                    {
                        // Add name at the beginning for some responses
                        string[] namePrefixes = { $"\n{userName}, ", $"\nHey {userName}, " };
                        if (random.Next(3) == 0)
                        {
                            response = namePrefixes[random.Next(namePrefixes.Length)] + response.ToLower();
                        }
                    }
                    return response;
                }
            }

            // Handle "tell me more"
            if (input.Contains("tell me more") || input.Contains("another tip") || input.Contains("more tips") || input.Contains("more information"))
            {
                if (!string.IsNullOrEmpty(userInterest))
                {
                    return $"👍 **Here's another tip about {userInterest}:**\n\n" + GetRandomResponse(userInterest);
                }
                else
                {
                    return "👍 **Here's a general cybersecurity tip:**\n\n" + GetRandomResponse("password");
                }
            }

            // Sentiment detection
            if (input.Contains("worried") || input.Contains("scared") || input.Contains("nervous") || input.Contains("anxious"))
            {
                return "😟 **I understand your concern.** Cybersecurity can feel overwhelming, but you're taking the right step by learning! The fact that you're worried shows you care about your safety. Let me share something to help you feel more secure.\n\n" + GetRandomResponse("password");
            }

            if (input.Contains("confused") || input.Contains("don't understand") || input.Contains("not sure"))
            {
                return "🤔 **Let me explain more clearly.** Cybersecurity terms can be confusing. Let me break it down simply.\n\n" + GetRandomResponse("help");
            }

            if (input.Contains("curious") || input.Contains("interesting") || input.Contains("want to learn"))
            {
                return "😊 **I'm glad you're curious about cybersecurity!** That curiosity will help you stay safe. Here's an important tip:\n\n" + GetRandomResponse("password");
            }

            if (input.Contains("frustrated") || input.Contains("annoying") || input.Contains("tired"))
            {
                return "😤 **I hear your frustration.** Cybersecurity can feel like a hassle, but small steps make a big difference. Take it one tip at a time. What specific topic would you like to learn about?\n\nType 'help' to see available topics.";
            }

            // Default response
            return GetRandomDefaultResponse();
        }

        private string GetRandomResponse(string keyword)
        {
            if (responses.ContainsKey(keyword) && responses[keyword].Count > 0)
            {
                return responses[keyword][random.Next(responses[keyword].Count)];
            }
            return GetRandomDefaultResponse();
        }

        private string GetRandomDefaultResponse()
        {
            string[] defaults = {
                "🤖 **I didn't understand that.** Try typing: **password**, **phishing**, **scam**, **privacy**, **safe browsing**, or **2fa**\n\nType **help** to see all topics.",

                "💭 **Not sure what you mean.** I can help with cybersecurity topics like passwords, phishing scams, online privacy, and safe browsing.\n\nType **help** to see what I can answer!",

                "📚 **I'm still learning!** Try asking about:\n• **password** (strong passwords)\n• **phishing** (fake emails)\n• **scam** (South African scams)\n• **privacy** (protect your info)\n• **2fa** (extra security)",

                "🔐 **Ask me about cybersecurity!** I can teach you about:\n• Creating strong passwords\n• Spotting phishing emails\n• Avoiding common scams in SA\n• Protecting your online privacy\n\nJust type a topic like **password** or **phishing**!"
            };
            return defaults[random.Next(defaults.Length)];
        }
    }
}