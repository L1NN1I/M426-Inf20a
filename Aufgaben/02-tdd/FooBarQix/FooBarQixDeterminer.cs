namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string output = "";

            if (input % 3 == 0) {
                output = "Foo";
            }

            if (input % 5 == 0) {
                output += "Bar";
            }


            if (input % 7 == 0) {
                output += "Qix";
            }

            if (output == "") {
                output = input.ToString();
            }

            return output;
        }
    }
}