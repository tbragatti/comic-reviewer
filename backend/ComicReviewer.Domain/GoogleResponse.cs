namespace ComicReviewer.Domain;

public class GoogleResponse
{
   public int totalItems { get; set; }
   
   public List<VolumeInfo> Volume { get; set; }  

    public class VolumeInfo
    {
        public string Title { get; set; }

        public List<string> Authors { get; set; }
        public string Publisher { get; set; }
        public DateOnly DataPublicacao { get; set; }
        public string Descricao { get; set; }
        public int NumeroPaginas { get; set; }


    }
}
