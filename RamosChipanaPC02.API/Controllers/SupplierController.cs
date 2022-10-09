using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RamosChipanaPC02.DOMAIN.Core.Entities;
using RamosChipanaPC02.DOMAIN.Core.Interfaces;

namespace RamosChipanaPC02.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {

        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var suppliers = await _supplierRepository.GetSuppliers();
            return Ok(suppliers);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierById(int id)
        {
            var supplier = await _supplierRepository.GetSupplier(id);
            return Ok(supplier);
        }


        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Supplier supplier)
        {
            var result = await _supplierRepository.Insert(supplier);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Supplier supplier)
        {
            if (id != supplier.Id)
                return BadRequest();

            var result = await _supplierRepository.Update(supplier);
            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _supplierRepository.Delete(id);
            return Ok(result);
        }


    }
}
