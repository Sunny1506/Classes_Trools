using Modelos;

namespace Controles;

public class EnviocorteControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnviocorteControle () : base()
  {
    NomeDaTabela = "Enviocorte";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Enviocorte>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Enviocorte? LerTodos()
  {
    var tabela = liteDB.GetCollection<Enviocorte>(NomeDaTabela);
    return new List<Enviocorte>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Enviocorte>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Enviocorte enviocorte)
  {
    var collection = liteDB.GetCollection<Enviocorte>(NomeDaTabela);
    collection.Upsert(enviocorte);
  }

  //----------------------------------------------------------------------------
}