namespace Lab2.HomeWorks
{
  public class Patient : Person, Iprimary_care_doctor
{
     
    
    public override void get_treatment()
    {
        Console.WriteLine("������ ���� �������");
    }
     
    
    public void provide_treatment()
    {
        Console.WriteLine("�������� ���� �������");
    }
}
 
}