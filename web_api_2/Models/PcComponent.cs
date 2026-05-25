namespace web_api_2.Models;

public class PcComponent
{
    public int PCId { get; set; }
    public Pc PC { get; set; } = null!;
    
    public string ComponentCode { get; set; } = null!;
    public Component Component { get; set; } = null!;

    public int Amount { get; set; }
}