using EntidadesDAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace TesteVagasCadastro.Api.Controllers
{
    public class ContasController : ApiController
    {
        private TesteVagasModelo db = new TesteVagasModelo();

        // GET: api/Contas
        [Route("contas")]
        public IQueryable<Conta> GetContas()
        {
            return db.Contas;
        }

        // GET: api/Contas/5
        [ResponseType(typeof(Conta))]
        [Route("getcontas")]
        public IHttpActionResult GetConta(int id)
        {
            Conta conta = db.Contas.Find(id);
            if (conta == null)
            {
                return NotFound();
            }

            return Ok(conta);
        }

        // PUT: api/Contas/5
        [ResponseType(typeof(void))]
        [Route("putcontas")]
        public IHttpActionResult PutConta(int id, Conta conta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != conta.Id)
            {
                return BadRequest();
            }

            db.Entry(conta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaExists(id))
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

        // POST: api/Contas
        [ResponseType(typeof(Conta))]
        [Route("postcontas")]
        public IHttpActionResult PostConta(Conta conta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contas.Add(conta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = conta.Id }, conta);
        }

        // DELETE: api/Contas/5
        [ResponseType(typeof(Conta))]
        [Route("deletecontas")]
        public IHttpActionResult DeleteConta(int id)
        {
            Conta conta = db.Contas.Find(id);
            if (conta == null)
            {
                return NotFound();
            }

            db.Contas.Remove(conta);
            db.SaveChanges();

            return Ok(conta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContaExists(int id)
        {
            return db.Contas.Count(e => e.Id == id) > 0;
        }
    }
}