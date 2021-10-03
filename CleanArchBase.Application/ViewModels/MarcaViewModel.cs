﻿using System.Collections.Generic;

namespace CleanArchBase.Application.ViewModels
{
    public class MarcaViewModel : BaseProduto
    {
        public int IdCategoria { get; set; }
        public List<CategoriaViewModel> Categorias { get; set; }
    }

}
