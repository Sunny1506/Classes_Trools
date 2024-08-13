using Modelos;

namespace Controles;

public class EnvioacabamentoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public EnvioacabamentoControle () : base()
  {
    NomeDaTabela = "Envioacabamento";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Envioacabamento>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Envioacabamento>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Envioacabamento>(NomeDaTabela);
    return new List<Envioacabamento>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Envioacabamento>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Envioacabamento envioacabamento)
  {
    var collection = liteDB.GetCollection<Envioacabamento>(NomeDaTabela);
    collection.Upsert(envioacabamento);
  }

  //----------------------------------------------------------------------------
}