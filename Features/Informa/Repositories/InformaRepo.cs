using MediatrTest.Domain;

namespace MediatrTest.Features.Informa.Repositories
{
    public class InformaRepo : IInformaRepo
    {
        private static List<Newsletter> _newsletters = default!;
        public InformaRepo()
        {
            _newsletters = [
                new Newsletter
                {
                    DatePublication = new DateOnly(1978, 12, 29),
                    Id = 1,
                    IsProcessed = false,
                    Name = "Cortes Generales",
                    Text = "La Nación española, deseando establecer la justicia, la libertad y la seguridad y promover el bien de cuantos la integran, en uso de su soberanía, proclama su voluntad ...",
                    Url = @"https://www.boe.es/buscar/doc.php?id=BOE-A-1978-31229"
                },
                new Newsletter
                {
                    DatePublication = new DateOnly(1978, 12, 29),
                    Id = 2,
                    IsProcessed = false,
                    Name = "Cortes Generales",
                    Text = "La Nación española, deseando establecer la justicia, la libertad y la seguridad y promover el bien de cuantos la integran, en uso de su soberanía, proclama su voluntad ...",
                    Url = @"https://www.boe.es/buscar/doc.php?id=BOE-A-1978-31229"
                },
                new Newsletter
                {
                    DatePublication = new DateOnly(1978, 12, 29),
                    Id = 3,
                    IsProcessed = false,
                    Name = "Cortes Generales",
                    Text = "La Nación española, deseando establecer la justicia, la libertad y la seguridad y promover el bien de cuantos la integran, en uso de su soberanía, proclama su voluntad ...",
                    Url = @"https://www.boe.es/buscar/doc.php?id=BOE-A-1978-31229"
                },
                new Newsletter
                {
                    DatePublication = new DateOnly(1978, 12, 29),
                    Id = 4,
                    IsProcessed = false,
                    Name = "Cortes Generales",
                    Text = "La Nación española, deseando establecer la justicia, la libertad y la seguridad y promover el bien de cuantos la integran, en uso de su soberanía, proclama su voluntad ...",
                    Url = @"https://www.boe.es/buscar/doc.php?id=BOE-A-1978-31229"
                }
            ];
        }
        public async Task Add(Newsletter newsletter)
        {
            _newsletters.Add(newsletter);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Newsletter>> GetAll() => await Task.FromResult(_newsletters);

        public async Task<Newsletter?> GetById(int id) => await Task.FromResult(_newsletters.FirstOrDefault(item => item.Id == id));
    }
}
