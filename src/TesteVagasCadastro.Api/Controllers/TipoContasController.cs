using EntidadesDAL;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace TesteVagasCadastro.Api.Controllers
{
    public class TipoContasController : ApiController
    {
        private TesteVagasModelo db = new TesteVagasModelo();

        // GET: api/TipoContas
        [Route("tipocontas")]
        public IQueryable<TipoConta> GetTipoContas()
        {
            return db.TipoContas;
        }

        // GET: api/TipoContas/5
        [ResponseType(typeof(TipoConta))]
        [Route("gettipocontas")]
        public IHttpActionResult GetTipoConta(int id)
        {
            TipoConta tipoConta = db.TipoContas.Find(id);
            if (tipoConta == null)
            {
                return NotFound();
            }

            return Ok(tipoConta);
        }

        // PUT: api/TipoContas/5
        [ResponseType(typeof(void))]
        [Route("puttipocontas")]
        public IHttpActionResult PutTipoConta(int id, TipoConta tipoConta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoConta.Id)
            {
                return BadRequest();
            }

            db.Entry(tipoConta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoContaExists(id))
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

        // POST: api/TipoContas
        [ResponseType(typeof(TipoConta))]
        [Route("posttipocontas")]
        public IHttpActionResult PostTipoConta(TipoConta tipoConta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoContas.Add(tipoConta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipoConta.Id }, tipoConta);
        }

        // DELETE: api/TipoContas/5
        [ResponseType(typeof(TipoConta))]
        [Route("deletetipocontas")]
        public IHttpActionResult DeleteTipoConta(int id)
        {
            TipoConta tipoConta = db.TipoContas.Find(id);
            if (tipoConta == null)
            {
                return NotFound();
            }

            db.TipoContas.Remove(tipoConta);
            db.SaveChanges();

            return Ok(tipoConta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoContaExists(int id)
        {
            return db.TipoContas.Count(e => e.Id == id) > 0;
        }
    }
}