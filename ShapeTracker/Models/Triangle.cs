namespace ShapeTracker.Models
{
  public class Triangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; }

    public Triangle(int length1, int length2)
    {
      _side1 = length1;
      Side2 = length2;
    }
  }
}