
public class Dice
{


  private int slides;
  
  public int Slides{
    get { return slides; }
    set
    {
      if (value <= 0) slides = 1;
      else slides = value;
    }
  }

  public int roll()
  {
    return new Random().Next(1, slides + 1);
  }
}