
using static DioSeries.src.Interfaces.IRepositorio;

namespace DioSeries;

public class SerieRepositorio : IRepositorio<Series>
{
    private List<Series> listaSeries = new List<Series>();
    
    public void Atualiza(int id, Series entidade)
    {
        listaSeries[id] =  entidade;
    }

    public void Exclui(int id)
    {
        listaSeries[id].Exclui();
    }

    public void Insere(Series entidade)
    {
        listaSeries.Add(entidade);
    }

    public List<Series> Lista()
    {
       
       return listaSeries;
    }

    public int ProximoId()
    {
        return listaSeries.Count;
     }

    public Series RetornaPorId(int id)
    {
        return listaSeries[id];
    }
}