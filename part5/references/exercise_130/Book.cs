namespace exercise_130
{


  public class Book
  {

    private string name;
    private int publicationYear;

    public Book(string name, int publicationYear)
    {
      this.name = name;
      this.publicationYear = publicationYear;
    }


    // BEGIN SOLUTION
    public override bool Equals(object compared)
    {
      if (this == compared)
      {
        return true;
      }

      // if the compared object is null or not of type Book, the objects are not equal
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      Book comparedBook = (Book)compared;

      // if the values of the object variables are the same, the objects are equal
      if (this.name == comparedBook.name &&
          this.publicationYear == comparedBook.publicationYear)
      {
        return true;
      }
      // otherwise the objects are not equal
      return false;
    }
    // END SOLUTION
  }


}