using System.Collections.Generic;

namespace CleanArchBase.Application.ViewModels
{
    public class ModeloViewModel
    {
        public int IdMarca { get; set; }
        public List<MarcaViewModel> Marcas { get; set; }
    }
}
