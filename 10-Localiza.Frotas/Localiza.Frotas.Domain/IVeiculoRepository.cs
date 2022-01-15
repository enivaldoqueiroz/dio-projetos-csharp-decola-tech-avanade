using System;
using System.Collections.Generic;
using System.Text;

namespace Localiza.Frotas.Domain
{
    public interface IVeiculoRepository
    {
        Veiculo GetVeiculo(Guid id);

        IEnumerable<Veiculo> GetAll();

        void Add(Veiculo veiculo);
        void Delete(Veiculo veiculo);
        void Update(Veiculo veiculo);
        Veiculo GetById(Guid id);
        void Delete(object veiculo);
    }
}
