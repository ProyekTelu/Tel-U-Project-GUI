
namespace Model
{
    public class Proyek
    {
        private String id_proyek { get; set; }
        private String judul { get; set; }
        private String deskripsi { get; set; }
        private String program_studi { get; set; }
        private String skill { get; set; }
        private DateTime batas_pendaftaran { get; set; }
        private Dosen manager { get; set; }
        private List<Tim_Proyek> ListTimProyek { get; set; }

        public Proyek(Dosen Smanager, Tim_Proyek tim_proyek)
        {
            this.manager = manager;
            ListTimProyek = new List<Tim_Proyek>();
            ListTimProyek.Add(tim_proyek);
        }
    }
}
