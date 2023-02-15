//Main
int GetUser = UserInput();
string PyramidInput = PyramidShape(GetUser);
//System.Console.WriteLine(PyramidInput); reads the if statement properly
BuildPyramid(PyramidInput);
//End

static int UserInput() {
    System.Console.WriteLine("What condition is the pyramid in?");
    System.Console.WriteLine("Press 1 for Mint Condition:");
    System.Console.WriteLine("Press 2 for Modern Day Condition:");
    System.Console.WriteLine("Press 3 to Exit:");
    return int.Parse(Console.ReadLine());
}

static string PyramidShape(int GetUser) {
    if(GetUser==1) {
        return "mint";
    }
    else if(GetUser==2) {
        return "modern day";
    }
    else if(GetUser==3) {
        return "exit";
    }
    else return "wrong input";
}

static string BuildPyramid(string PyramidInput) {
    Random rnd = new Random();
    int number = rnd.Next(3,9);
    
    if(PyramidInput=="mint") {

        for(int column = 0; column <= number ; column++) {
            for(int row = 5; row <= 1; row--) {
                System.Console.Write(" ");
        
            }
            for(int block = 1; block <= column-1; block++) {
                System.Console.Write("0");
            }
            System.Console.WriteLine();
        }
    }
    ///can read mint pyramid
    
	if(PyramidInput=="modern day") {
        Random rnd1 = new Random();
        int number1 = rnd1.Next(1,3);
        for(int column = 0; column <= number ; column++) {
            for(int row = 5; row <= 1; row--) {
                System.Console.Write(" ");
        
            }
            for(int block = 1; block <= column-1; block++) {
                if(number1 == rnd1.Next(1,3)) {
                    System.Console.Write("0");
                }
                else if(number1 == 2) {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }        

	if(PyramidInput=="exit") {
        System.Console.WriteLine("");
    }
    return "wrong input";
}



