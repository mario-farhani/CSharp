using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using MyInterface;

namespace HelloWorld
{

    class Program
    {
        /*
         * This format is used for commenting 
         * use it this way for multi-line comment
         */

        static void Main(string[] args)
        {
            BasicString strExample = new BasicString();
            strExample.BasicStringFunction();
            // -------------------------- Actions --------------------------------------
            Action1 act = new Action1();
            act.ActionFunction();
            //-----------------------------------------Declaration---------------------------
            Declration dcl = new Declration();
            dcl.DeclrationFuction();
            // ----------------------------------- mathematic--------------------------
            Mathematic math = new Mathematic();
            math.MathematicFunction();
            //----------------------------Strings---------------------------------//
            Strings st = new Strings();
            st.StringsFuction();
            //---------------------------------Trapezoid---------------------//
            Trapezoid trp = new Trapezoid();
            trp.TrapezoidFunc();
            //-------------------------Switch---------------------------------------//
            Switch sw = new Switch();
            sw.SwitchFun();
            //---------------------------Array_________________________________//
            Arrays ary = new Arrays();
            ary.ArraysFun();
            //----------------------------lsit----------------------//
            Lists lst = new Lists();
            lst.ListsFunc();
            //--------------------------dictionary----------------------//
            Dictionaries dct = new Dictionaries();
            dct.DictionaryFuc();
            //-------------------------------------enum--------------------------------//
            Enumss enm = new Enumss();
            enm.EnumssFuc();
            //----------------------------------property----------------------------//
            Prpty prt = new Prpty();
            prt.PrptyFunc();
            //-----------------------------exception--------------------------------//
            Expt exp = new Expt();
            exp.ExptFunc();
            //--------------------------------Access--------------------------------------//
            TestAccess tac = new TestAccess();
            tac.MethodToGet();
            //--------------------------------Access when static-------------------------------------//
            TestAccessStatic.MethodStatic();

            //---------------------------------Property Extend---------------------------------------//
            NewProjector myProjectorObject = new NewProjector();
            myProjectorObject.Manufacturer = "Panasonic";
            myProjectorObject.MaxLampHour = 20000;
            myProjectorObject.LampHour = 10000;
            Console.WriteLine("Projector Manufacturer = {0} and has {1} lamp hours.",
                myProjectorObject.Manufacturer, myProjectorObject.LampHour);
            myProjectorObject.LampHour = 19500;

            Console.WriteLine("Projector Manufacturer = {0} and has {1} lamp hours.",
                myProjectorObject.Manufacturer, myProjectorObject.LampHour);
            Console.WriteLine();
            //-----------------------------------Delegates---------------------------------------------------//
            Delegates dlg = new Delegates();
            dlg.DeligateFunc();
            Console.WriteLine();
            // ----------------------- event--------------------------//
            WorkingClass wc = new WorkingClass();
            Console.WriteLine();

            //-----------------------------timer/ sleep------------------//
            Timer tm = new Timer();
            tm.TimerFunc();
            Console.WriteLine();

            // ----------------------------------Thread--------------------//
            Threads thrd = new Threads();
            thrd.ThreadFunc();
            Console.WriteLine();
            ///----------------------------PolyMorphism-------------------//
            DrawShapes drw = new DrawShapes();
            drw.DrawFunc();
            Console.WriteLine();
            //---------------------- interface-------------------//
            Interfaces intfs = new Interfaces();
            intfs.InterfacesFunc();
            Console.WriteLine();
            //---------------------reflection---------------------//
            Reflections rfl = new Reflections();
            rfl.RefFunc();
            Console.WriteLine();

            //--------------------ReflectionWithInterface--------------------//
            RefWithIntface.RWFFunc();
            Console.WriteLine();

            //-----------------lambda--------------------//
            LambdaBasic.LambdaFun();


            //----------------------------------------------------------------//
            Console.WriteLine();
            Console.WriteLine();
            /*
            long infLoop = 10;
            Console.WriteLine($"X value = {infLoop}");
            while (infLoop < 1E10)
            { 
                infLoop *= 2; 
                Console.WriteLine($"X value = {infLoop}"); 
            };*/

            // wait for the user to read

            Console.WriteLine("End of program!");
            Console.Read();
        }
    }

    class BasicString
    {
        public void BasicStringFunction()
        {
            int num = 10;
            String str = "John";

            //Printing strings and using Methods to edit the text

            Console.WriteLine("Hello World!"); // print the string on console

            Method("Mario");
            Method("Jack");
            Method();
            Method1($"Hello {str}. {str} has {str.Length} characters");
            Method1(2);

            Console.WriteLine("print some stars:");
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //trim - remove leaading and tailing spaces
            string greeting1 = "      Hello World!       ";
            Console.WriteLine($"[{greeting1}]");

            string trimmedGreeting = greeting1.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting1.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting1.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            Console.WriteLine("\n");

            //replace - search for a substring and replace it with differnt one
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine("\n");

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine("\n");

            //search
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.ToLower().StartsWith("you"));
            Console.WriteLine(songLyrics.StartsWith("you"));
            Console.WriteLine(songLyrics.EndsWith("you"));
            Console.WriteLine(songLyrics.IndexOf('o'));
            songLyrics = songLyrics.Insert(15, ",,");
            //songLyrics = songLyrics.Remove(15);
            Console.WriteLine(songLyrics);
            Console.WriteLine(songLyrics.Length);
            string subSongLyrics = songLyrics.Substring(5, songLyrics.Length - 5);
            subSongLyrics.Substring(15);
            Console.WriteLine(subSongLyrics);
            Console.WriteLine("\n");

        }
        static void Method(string name = "default")
        {
            Console.WriteLine(name + "!");
        }

        static void Method1(int num)
        {
            Console.WriteLine(num + "!");
        }

        static void Method1(string name)
        {
            Console.WriteLine(name + "!");
        }
    }

    class Action1
    {
        public void ActionFunction()
        {
            Action a = () => Console.Write("alpha");
            Action b = () => Console.Write("beta\n");
            Action ab = a + b;
            ab();  // output: alphabeta


            int num2 = 5;
            num2 += 9;
            Console.WriteLine(num2);
            // Output: 14

            string story = "Start. ";
            story += "End.";
            Console.WriteLine(story);
            // Output: Start. End.

            Action printer = () => Console.Write("1st String.");
            printer();  // output: 1st String.

            Console.WriteLine();
            printer += () => Console.Write("\tadded String");
            printer();  // output: added String
            Console.WriteLine("\n");
        }
    }

    class Declration
    {
        public void DeclrationFuction()
        {
            int num3 = 32;
            uint num4 = 32;
            //uint num5 = -2; //non-negetive number
            ushort num6 = 65535;
            //ushort num7 = 66535; max reached
            long num8 = 1000000000000;
            byte num9 = 255; //max
            char ch1 = 'h';
            string st1 = "hello";
            var vr1 = "determined at runtime";
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(uint.MinValue);
            int max = int.MaxValue;
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            ushort teaspoon;    //2 bytes
            uint teacup;        //4 bytes
            ulong bucket;       //8 bytes

            float coffeemug;    //4 bytes but uses decimal - greatre precision
            double bathtube;    //8 bytes but uses decimal - greatre precision
            //decimal : 16 bytes

            // implicit conversion - the data will fit and no information is lost
            teaspoon = 3524;    //5ml of volume
            teacup = teaspoon;
            bucket = teacup;

            coffeemug = teacup;
            bathtube = coffeemug;

            Console.WriteLine("--- Implicit ---\n" +
                                "teaspoon = {0}\n" +
                                "teacup = {1}\n" +
                                "bucket = {2}\n" +
                                "coffeemug = {3}\n" +
                                "bathtub = {4}\n"
                                , teaspoon
                                , teacup
                                , bucket
                                , coffeemug
                                , bathtube);
            // explicit conversion - some percision or data may be lost
            bathtube = 65539.259256;
            coffeemug = (float)bathtube;
            teaspoon = (ushort)coffeemug;

            bucket = (ulong)coffeemug;
            teacup = (uint)bucket;
            teaspoon = (ushort)teacup;

            Console.WriteLine("--- Explicit ---\n" +
                                "bathtub = {0}\n" +
                                "coffeemug = {1}\n" +
                                "bucket = {2}\n" +
                                "teacup = {3}\n" +
                                "teaspoon = {4}\n"
                                , bathtube
                                , coffeemug
                                , bucket
                                , teacup
                                , teaspoon);

            //String conversion
            string chain = "abcd";
            char link = 'e';

            chain += link; //implicit
            Console.WriteLine("Total chain = {0}", chain);

            //Helper Classes - Convert
            int z = Convert.ToInt32("1234");
            Console.WriteLine("String to int : {0}", z);

            //Built-in Methods
            int num10, num11;
            int.TryParse("12$4", out num10);  //will return 0 due to '$'
            int.TryParse("789", out num11);
            Console.WriteLine("TryParse Operasion: a = {0}, b = {1}", num10, num11);
            Console.WriteLine("\n");
        }
    }
    class Mathematic
    {
        public void MathematicFunction()
        {
            int x = 35, y = 10;

            y = ++x;
            int yy = x++;
            Console.WriteLine(y);
            Console.WriteLine(yy);
            Console.WriteLine(x);
            Console.WriteLine("\n");

            float tempC = 22.5f, tempF;
            tempF = (tempC * 9) / 5 + 32;
            Console.WriteLine($"Temp in F is: {tempF}");

            //bits
            int num12 = 2, num13 = 3, num14 = 0;// in binary 0010, 0011, 0000
            num14 = num12 & num13;
            num14 = num12 | num13;
            num14 = num12 ^ num13;
            num14 = num12 << 2;
            num14 = num13 >> 1;

            Console.WriteLine(num14);


            //password
            Console.WriteLine("Please enter password:");
            string password = Console.ReadLine();
            if (password == "Crestron")
            {
                Console.WriteLine("Welcome to the system!");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }

            Console.WriteLine("\n");
        }
    }

    class Strings
    {
        public void StringsFuction()
        {
            // Declare without initializing.
            string message1;

            // Initialize to null.
            string message2 = null;

            // Initialize as an empty string.
            // Use the Empty constant instead of the literal "".
            string message3 = System.String.Empty;

            // Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

            // Initialize with a verbatim string literal.
            string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

            // Use System.String if you prefer.
            System.String greeting = "Hello World!";

            // In local variables (i.e. within a method body)
            // you can use implicit typing.
            var temp = "I'm still a strongly-typed System.String!";
            Console.WriteLine(temp);

            // Use a const string to prevent 'message4' from
            // being used to store another string value.
            const string message4 = "You can't get rid of me!";

            // Use the String constructor only when creating
            // a string from a char*, char[], or sbyte*. See
            // System.String documentation for details.
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);

            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2022d - jh.born) / 100d) * 100d} years old today.");
            Console.WriteLine("\n");


            string s5 = "Printing backwards";
            for (int i = 0; i < s5.Length; i++)
            {
                System.Console.Write(s5[s5.Length - i - 1]);
            }
            Console.WriteLine("\n");

            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

            for (int j = 0; j < sb.Length; j++)
            {
                if (System.Char.IsLower(sb[j]) == true)
                    sb[j] = System.Char.ToUpper(sb[j]);
                else if (System.Char.IsUpper(sb[j]) == true)
                    sb[j] = System.Char.ToLower(sb[j]);
            }
            // Store the new string.
            string corrected = sb.ToString();
            System.Console.WriteLine(corrected);
            // Output: How does Microsoft Word deal with the Caps Lock key?

            Console.WriteLine("\n");

        }
    }
    class Trapezoid
    {
        public void TrapezoidFunc()
        {
            MathTrapezoidSample trpz = new MathTrapezoidSample(20.0, 10.0, 8.0, 6.0);
            Console.WriteLine("The trapezoid's bases are 20.0 and 10.0, the trapezoid's legs are 8.0 and 6.0");
            double h = trpz.GetHeight();
            Console.WriteLine("Trapezoid height is: " + h.ToString());
            double dxR = trpz.GetLeftBaseRadianAngle();
            Console.WriteLine("Trapezoid left base angle is: " + dxR.ToString() + " Radians");
            double dyR = trpz.GetRightBaseRadianAngle();
            Console.WriteLine("Trapezoid right base angle is: " + dyR.ToString() + " Radians");
            double dxD = trpz.GetLeftBaseDegreeAngle();
            Console.WriteLine("Trapezoid left base angle is: " + dxD.ToString() + " Degrees");
            double dyD = trpz.GetRightBaseDegreeAngle();
            Console.WriteLine("Trapezoid left base angle is: " + dyD.ToString() + " Degrees");

        }
    }

    class Switch
    {
        public void SwitchFun()
        {
            ushort incoming = 0;
            do
            {
                Console.WriteLine("Enter incoming value: ");
                try
                {
                    incoming = ushort.Parse(Console.ReadLine());
                    switch (incoming)
                    {
                        case 1:
                            {
                                Console.WriteLine("1");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("2");
                                break;
                            }
                        case 3:         //case 3 and4 and 5 return case 5
                        case 4:
                        case 5:
                            {
                                Console.WriteLine("5");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Default");
                                break;
                            }

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Enter an integer!");
                    incoming = 10;
                }


            } while (incoming != 0);
        }
    }

    class Arrays
    {
        public void ArraysFun()
        {
            int[,] aa = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
            //Console.WriteLine(aa.GetLength(0));
            //Console.WriteLine(aa.GetLength(1));
            for (int i = 0; i < aa.GetLength(0); i++)
            {
                for (int j = 0; j < aa.GetLength(1); j++)
                {
                    Console.WriteLine("X={0},Y={1},Data={2}", i, j, aa[i, j]);
                }
            }
            Console.WriteLine();
            int[,,] bb = new int[3, 4, 2] { { { 0, 1 }, { 2, 3 }, { 0, 1 }, { 2, 3 } }
                                          , { { 4, 5 }, { 6, 7 }, { 4,5  }, { 5, 7 } }
                                          , { { 8, 9 }, { 10, 11 } , { 8 , 9 } , { 10 , 11 } }};

            for (int i = 0; i < bb.GetLength(0); i++)
            {
                for (int j = 0; j < bb.GetLength(1); j++)
                {
                    for (int k = 0; k < bb.GetLength(2); k++)
                    {
                        Console.WriteLine("X={0},Y={1},Z={2},Data={3}", i, j, k, bb[i, j, k]);
                    }
                }
            }
            Console.WriteLine();

            //jagged array

            int[][] aaa = new int[3][]
            {
                new int[4] {1,2,3,4 },
                new int[3] {1,2,3 },
                new int[2] {8,9 }

            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < aaa[i].Length; j++)
                {
                    Console.WriteLine("Array={0}, Y={1}, Data={2}", i, j, aaa[i][j]);
                }
            }
            Console.WriteLine();
        }
    }

    class Lists
    {
        public void ListsFunc()
        {
            var names = new List<string> { "Mario", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Jack");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");
            Console.WriteLine();

            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }

    class Dictionaries
    {
        public void DictionaryFuc()
        {
            Dictionary<string, string> myCrestronClass;
            myCrestronClass = new Dictionary<string, string>
            {
                { "P101", "Foundation of Crestron Programming" },
                { "P102", "Core System Programming"}
            };
            myCrestronClass.Add("P103", "Advanced Programming Skill");
            myCrestronClass.Add("P104", "Master");

            myCrestronClass.Remove("P101");

            Console.WriteLine(myCrestronClass);
            foreach (var item in myCrestronClass)
            {
                Console.WriteLine($"Class ID = {item.Key}, Description = {item.Value}");
            }
            string str;
            if (myCrestronClass.TryGetValue("P101", out str))
                Console.WriteLine(str);
            else
                Console.WriteLine("Not Found!");

            Console.WriteLine();
        }
    }

    class Enumss
    {
        public void EnumssFuc()
        {
            Level volVar = Level.Low;
            Console.WriteLine(volVar.ToString());
            Console.WriteLine((int)volVar);
            Console.WriteLine();
        }
        public enum Level
        {
            Low = -1,
            Med = 0,
            High = 1
        }
    }

    class Prpty
    {
        public void PrptyFunc()
        {
            MyProperty = 9; //set the value
            Console.WriteLine($"The value of MyProperty = {MyProperty}");
            WorkingProperty = 7; //set the value
            WorkingProperty = 21;
            Console.WriteLine($"The value of WorkingProperty = {WorkingProperty}");
            Console.WriteLine();
        }

        static public int MyProperty { get; set; }

        static private int workingProperty;

        static public int WorkingProperty
        {
            get => workingProperty;
            set   //WorkingProperty = 8
            {
                if (value > 0 && value < 11)
                    workingProperty = value;
            }
        }
    }

    class Expt
    {
        public void ExptFunc()
        {
            DoMath(100, 20);
            Console.WriteLine("Math result is = {0}", z1);
            z1 = 0;
            try
            {
                DoMath(20, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                DoMath(20, 0);
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine("Devided by zero source = {0}", e.Source); // which program
                //Console.WriteLine("Devided by zero site = {0}", e.TargetSite); // which method
                Console.WriteLine("Devided by zero stak = {0}", e.StackTrace); // which line
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (z1 <= 1)
                    z1 = 1;
            }
            Console.WriteLine("Math result is = {0}", z1);

            Console.WriteLine();
        }
        static int z1;

        static void DoMath(int x, int y)
        {
            z1 = x / y;
        }
    }

    class TestAccess
    {
        public void MethodToGet()
        {

        }
    }

    static class TestAccessStatic
    {
        static public void MethodStatic()
        {

        }
    }

    class NewProjector
    {
        /* Definitin: field & property
         * Field -> is a variable that is declared directly in a class or struct.
         * Property -> is a member that provides a flexible mechanism to read, write or compute
         * the value of private field
         */
        private string _manufacturer;   //Field
        private string _modelNumber;
        private uint _maxLampHour;
        private uint _lampHour;

        public string Manufacturer      //property
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        private string ModelNumber
        {
            get { return _modelNumber; }
            set { _modelNumber = value; }
        }

        public uint MaxLampHour
        {
            get { return _maxLampHour; }
            set { _maxLampHour = value; }
        }

        public uint LampHour
        {
            get { return _lampHour; }
            set
            {
                _lampHour = value;
                if ((double)_lampHour / _maxLampHour > 0.90)
                {
                    Console.WriteLine("Projector Maintenance Required");
                }
            }
        }

    }

    class Delegates
    {
        delegate void MathDelegate();

        static int result = 0;

        public void DeligateFunc()
        {
            SetStartingValueOfTwo();
            Console.WriteLine("result = {0}\n", result);

            // assign a single method to the delegate
            MathDelegate tester = AddTwo;
            // replace the assigned method 
            tester = AddFour;

            // invoke teh delegate. i.e. run the assigned method
            tester();
            Console.WriteLine("Tester result = {0}\n", result);

            //multiple operation => 2+3+4=9

            //create a Multicast Delegate (more than one method called)
            MathDelegate add2 = AddTwo;
            MathDelegate add3 = AddThree;
            MathDelegate add4 = AddFour;

            // create a Multiast Delegate (more than one method is called)
            MathDelegate multicast = add2 + add3;
            multicast += add4;

            //invoke the delegate
            multicast();

            Console.WriteLine("Multicast Delegate result = {0}\n", result);

            // 2+2*4 =10
            MathDelegate BEDMAS = SetStartingValueOfTwo;
            BEDMAS += AddTwo;
            BEDMAS += TimesFour;

            //check order of execution
            foreach (var item in BEDMAS.GetInvocationList())
            {
                Console.WriteLine("Method to execute = {0}", item.Method);
            }
            BEDMAS();
            Console.WriteLine("Result = {0} , BEDMAS = {1}!", result, result == 10 ? "Yes" : "NO");

            // Correction
            BEDMAS -= add2;
            BEDMAS += add2;

            foreach (var item in BEDMAS.GetInvocationList())
            {
                Console.WriteLine("Method to execurte = {0}", item.Method);
            }

            BEDMAS();
            Console.WriteLine("Result = {0} , BEDMAS = {1}!", result, result == 10 ? "Yes" : "NO");
        }

        static void SetStartingValueOfTwo() { result = 2; }
        static void AddTwo() { result += 2; }
        static void AddThree() { result += 3; }
        static void AddFour() { result += 4; }
        static void TimesFour() { result *= 4; }
    }

    class WorkingClass
    {
        CustomArgs ca = new CustomArgs();
        public WorkingClass()
        {
            EventDetails ed = new EventDetails();
            //Subscribe to event 
            //subscriber #1
            ed.myEventToRun2 += new EventHandler(MyEventHandlerMethod); //because we add custom argument ths will no longer work
            //subsciber #2
            ed.myEventToRun += Ed_myEventToRun;
            AssignCustomArgs(111, "I am first");
            ed.MethodToTriggerEvent(ca); // needed some way to trigger event
            AssignCustomArgs(222, "I am second");
            ed.MethodToTriggerEvent(ca); // needed some way to trigger event
        }

        private void Ed_myEventToRun(object sender, CustomArgs e)
        {
            /*   Console.WriteLine("Second Subscriber was trigered by the Event!");
               Console.WriteLine("Event Publisher was = {0}\n", sender);*/
            //take incoming arguments and display value
            Console.WriteLine("Incoming data; number = {0} , text = {1}", e.NumericValue, e.StringValue);
        }

        void MyEventHandlerMethod(object sender, EventArgs e)
        {
            Console.WriteLine("First Subscriber was trigered by the Event!");
            Console.WriteLine("Event Publisher was = {0}\n", sender);
        }

        void AssignCustomArgs(int numb, string txt)
        {
            ca.StringValue = txt;
            ca.NumericValue = numb;
        }
    }

    class EventDetails
    {
        /*// void EventHandler (object sender, EventArgs e);*/
        public event EventHandler myEventToRun2;
        // void EventHandler<TEventArg> (object sender, TEventArgs e);
        public event EventHandler<CustomArgs> myEventToRun;

        protected virtual void onEventTrigger(CustomArgs e)
        {
            //checking for subscribers before raising event
            if (myEventToRun != null)
            {
                //order of subscription
                /*
                var invokeList = myEventToRun.GetInvocationList();
                foreach(var item in invokeList)
                {
                    Console.WriteLine("Subscriber = {0} , Method {1}\n" , item.Target, item.Method);
                }
                */

                //This line raises the event sends out to subscribers
                myEventToRun(this, e);

            }
        }

        protected virtual void onEventTrigger2(EventArgs e)
        {
            //checking for subscribers before raising event
            if (myEventToRun2 != null)
            {
                //order of subscription

                var invokeList = myEventToRun.GetInvocationList();
                foreach (var item in invokeList)
                {
                    Console.WriteLine("Subscriber = {0} , Method {1}\n", item.Target, item.Method);
                }


                //This line raises the event sends out to subscribers
                myEventToRun2(this, e);

            }
        }


        /* This method represents any possible requirements to raise 
         * this event. Other code to monitor thresholds or take inputs
         * from devices could be used to run onEventTrigger(null);
         */
        public void MethodToTriggerEvent(CustomArgs custom)
        {
            onEventTrigger(custom); //no data to pass

        }
    }

    class CustomArgs : EventArgs   // to pass data to event
    {
        public int NumericValue { get; set; }
        public string StringValue { get; set; }
    }

    class Timer
    {
        public void TimerFunc()
        {
            Console.WriteLine("Enter 'start' or 's' to wait for 3 seconds:");
            string input = Console.ReadLine().ToLower();

            if (input.Equals("strat") || input.Equals("s"))
            {
                Console.WriteLine("{0} - starting the 3 seconds test ...", DateTime.Now);
                //--Sleep--//
                Thread.Sleep(3000);
                Console.WriteLine("{0} - 3 Second sleep is completed.\n", DateTime.Now);
                //--Timer--//
                System.Timers.Timer sysTimer = new System.Timers.Timer();
                sysTimer.Interval = 6000;
                sysTimer.AutoReset = false; //only run one time
                sysTimer.Elapsed += SysTimer_Elapsed;

                Console.WriteLine("{0} - Starting sysTimer!\n", DateTime.Now);
                sysTimer.Start();
                Console.WriteLine("Main thread keeps executing as the sysTimer is counting.\n");

                Thread.Sleep(5000);
                Console.WriteLine("Five second sleep is done!");

                //Synchronous operation 
                double x = Math.Sqrt(25);

                // *** Delay ***
                // Non-blocking call - uses another thread for execution
                // Asychronous operation based on whatever 'await' is doing
                Console.WriteLine("{0} - Pre 3-second delay.", DateTime.Now);
                var myTask = Task.Run(async () =>
               {
                   await Task.Delay(3000);
                   DelayOutput();
               });
                Console.WriteLine("{0} - Just after Task.Run", DateTime.Now);

                //myTask.Wait();
                Console.WriteLine("{0} - This only happens once the task is completed", DateTime.Now);

            }
        }

        private static void DelayOutput()
        {
            Console.WriteLine("{0} - Post 3-second delay.", DateTime.Now);
        }

        private static void SysTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("{0} - sysTimer has completed!", DateTime.Now);

            //throw new NotImplementedException();
        }
    }

    class Threads
    {
        public void ThreadFunc()
        {
            Thread myThread = new Thread(Work);
            Thread myThread2 = new Thread(Work2);

            //use the thread class
            MyWorker WorkerThread = new MyWorker();

            WorkerThread.Start();
            WorkerThread.Send("hello");
            WorkerThread.Send("hola");
            myThread.Start();
            myThread2.Start();

            Console.WriteLine("Sleepimg main!");
            Thread.Sleep(1000);

            WorkerThread.Stop();
        }

        static void Work()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Work reports i = {i}");
            }
            Console.WriteLine("Work finished!");
        }
        static void Work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Work2 reports i = {i}");
            }
            Console.WriteLine("Work2 finished!");
        }
    }

    class DrawShapes : Shapes
    {
        public void DrawFunc()
        {
            Shape c = new Circle();
            Shape r = new Rectangle();

            c.Draw();
            r.Draw();

            BaseDisplay myProj = new Projector();
            BaseDisplay myTv = new TvDisplay();

            myProj.Name = "My Projector";
            myTv.Name = " My TV";

            myProj.PowerOn(myProj.Name);
            myTv.PowerOn(myTv.Name);

        }
    }

    class Reflections
    {
        private static int a = 1, b = 2, c = 3;
        public void RefFunc()
        {
            Console.WriteLine($"a+b+c = {a + b + c}");
            Console.WriteLine("Enter the variable you wnt to change:");
            string VarnName = Console.ReadLine();

            //Reflection
            Type t = typeof(Reflections);
            Console.WriteLine("Our class type is" + typeof(Reflections));

            FieldInfo myFiledInfo = t.GetField(VarnName, BindingFlags.NonPublic | BindingFlags.Static); //varriable is private | static
            Console.WriteLine("myFiledInfo = " + myFiledInfo);
            if (myFiledInfo != null)
            {
                Console.WriteLine($"Current value of {myFiledInfo.Name} is {myFiledInfo.GetValue(null)}.\n Change the value to: ");
                string NewVllue = Console.ReadLine();

                int NewInt;
                if (int.TryParse(NewVllue, out NewInt))
                {
                    myFiledInfo.SetValue(null, NewInt);
                    Console.WriteLine($"After reflection the value of a+b+c = {a + b + c}");
                }
            }



        }
    }

    class RefWithIntface
    {
        public static void RWFFunc()
        {
            var myDll = Assembly.LoadFrom(@"..\..\..\..\myLibrary\bin\debug\MyLibrary.dll");

            Type[] myType = myDll.GetTypes();
            foreach (var t in myType)
            {
                Console.WriteLine($"Found {t.FullName} inside the DLL");
            }

            if (myType[0].IsClass == true) //is the first member of dll a class?
            {
                // create our instance of that class 
                IPluginInterface myDevice = (IPluginInterface)Activator.CreateInstance(myType[0]);

                // access member inside that class
                myDevice.a = 4;
                myDevice.Name = "Tom";
                myDevice.myMethod();
                myDevice.anotherMethod(99);

                myDevice.a = 10;
                myDevice.Name = "";
                myDevice.myMethod();
                myDevice.anotherMethod(15);

            }
        }
    }
    class LambdaBasic
    {
        public static void LambdaFun()
        {
            DataSets data = new DataSets();
            foreach (var item in data.MvxModels)
            {
                Console.WriteLine($"NVX Model : {item}");
            }

            int index = data.MvxModels.IndexOf("DM-VVX-D30");
            Console.WriteLine($"NVX Model {data.MvxModels[index]} found at index = {index}");

            // lambda expression------- p is item index and => is the 'where' (lmbda expression)
            index = data.MvxModels.FindIndex(p => p.Equals("DM-VVX-D30")); // input parameter => expression to evaluate
            Console.WriteLine($"NVX Model {data.MvxModels[index]} found at index = {index}");


            int lastIndex = data.MvxModels.LastIndexOf("60");
            Console.WriteLine($"Last NVX Model with '60' is  found at index = {lastIndex}");

            lastIndex = data.MvxModels.FindLastIndex(p => p.Contains("60")); // input parameter => expression to evaluate
            Console.WriteLine($"Last NVX Model with '60' in name is {data.MvxModels[lastIndex]} found at index = {lastIndex}");

            List<string> filteredData = data.MvxModels.FindAll(p => p.Contains("60")); // input parameter => expression to evaluate
            foreach (var item in filteredData)
            {
                Console.WriteLine($"NVX Model with '60' in name {item}");

            }
        }
    }
}
 
