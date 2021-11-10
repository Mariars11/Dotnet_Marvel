namespace src.Dto
{
    // dto = data transfer object; transferencia entre a aplicação e o usuario
    public class CreateHero
    {
        public string Name { get; set; }
        public string RealName { get; set; }
        public int? GroupId { get; set; } 
    }
}