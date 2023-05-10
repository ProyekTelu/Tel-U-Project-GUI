
namespace Model
{
    public class Tim_Proyek
    {
        private String id_team { get; set; }
        private String nama_tim { get; set;}
        private List<Mahasiswa> mahasiswa { get; set; }
        private Dosen dosen { get; set; }
    }
}
