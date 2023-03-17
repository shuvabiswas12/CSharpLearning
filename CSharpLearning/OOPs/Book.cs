namespace CSharpLearning.OOPs
{
    // A struct type is a value type that is typically used to encapsulate a group of variables that are similar.
    // A struct type can declare constructors, constants, fields, methods, properties, indexers, operators,
    // and nested types.

    // The following code is an example of use of a struct Book uses a record for a book
    // with four members, Title, Author, Price, and Year. The Main program creates an object of Book struct,
    // set its member values, and print the values.


    public struct Book
    {
        public string Name;
        public string Author;
        public decimal Price;
        public short Year;

        public override string ToString()
        {
            return $"Name= {Name}, Author= {Author}, Price= {Price}, Year={Year} \n";
        }
    }
}