using EntidadesDAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace TesteVagasCadastro.Api.Controllers
{
    public class ClientesContasController : ApiController
    {
        private TesteVagasModelo db = new TesteVagasModelo();

        // GET: api/ClientesContas
        [Route("clientescontas")]
        public IQueryable<ClientesConta> GetClientesContas()
        {
            return db.ClientesContas;
        }

        // GET: api/ClientesContas/5
        [ResponseType(typeof(ClientesConta))]
        [Route("getclientescontas")]
        public IHttpActionResult GetClientesConta(int id)
        {
            ClientesConta clientesConta = db.ClientesContas.Find(id);
            if (clientesConta == null)
            {
                return NotFound();
            }

            return Ok(clientesConta);
        }

        // PUT: api/ClientesContas/5
        [ResponseType(typeof(void))]
        [Route("putclientescontas")]
        public IHttpActionResult PutClientesConta(int id, ClientesConta clientesConta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clientesConta.Id)
            {
                return BadRequest();
            }

            db.Entry(clientesConta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientesContaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ClientesContas
        [ResponseType(typeof(ClientesConta))]
        [Route("postclientescontas")]
        public IHttpActionResult PostClientesConta(ClientesConta clientesConta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ClientesContas.Add(clientesConta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = clientesConta.Id }, clientesConta);
        }

        // DELETE: api/ClientesContas/5
        [ResponseType(typeof(ClientesConta))]
        [Route("deleteclientescontas")]
        public IHttpActionResult DeleteClientesConta(int id)
        {
            ClientesConta clientesConta = db.ClientesContas.Find(id);
            if (clientesConta == null)
            {
                return NotFound();
            }

            db.ClientesContas.Remove(clientesConta);
            db.SaveChanges();

            return Ok(clientesConta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientesContaExists(int id)
        {
            return db.ClientesContas.Count(e => e.Id == id) > 0;
        }
    }
}