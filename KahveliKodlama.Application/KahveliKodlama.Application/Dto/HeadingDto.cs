namespace KahveliKodlama.Application.Dto
{

    public class HeadingDto : BaseDto
    {
        public string HeadingName    { get; set; }
        public string HeadingContent  { get; set; }
        public string HeadingTag      { get; set; }
        public int    HeadingViews    { get; set; }
        
    }
}
