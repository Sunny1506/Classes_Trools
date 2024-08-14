
using Modelos;

namespace Controles;

public class ClientesControle : BaseControle
{
  //----------------------------------------------------------------------------

  public ClientesControle() : base()
  {
    NomeDaTabela = "Clientes";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int id)
  {
    var collection = liteDB.GetCollection<Clientes>(NomeDaTabela);
    return collection.FindOne(d => d.Id == id);
  }

  //----------------------------------------------------------------------------

  public virtual List<Clientes>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Clientes>(NomeDaTabela);
    return new List<Clientes>(tabela.FindAll().OrderBy(d => d.Nome));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int id)
  {
    var collection = liteDB.GetCollection<Clientes>(NomeDaTabela);
    collection.Delete(id);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Clientes clientes)
  {
    var collection = liteDB.GetCollection<Clientes>(NomeDaTabela);
    collection.Upsert(clientes);
  }

  //----------------------------------------------------------------------------
}