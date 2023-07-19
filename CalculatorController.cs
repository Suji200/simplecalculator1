using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace simplecalculator
{
    internal class CalculatorController : ApiController
    {
        Databasehandler dbHandler;
        public CalculatorController()
        {
            // Initialize the Databasehandler with the connection details
            dbHandler = new Databasehandler("mongodb://localhost:27017/?connectTimeoutMS=30000", "calculator", "calculatorresult");
        }

        // POST api/calculator
        public IHttpActionResult Post(int operand1, int operand2, string operation, int result)
        {
            // Store the calculation data in the database
            dbHandler.StoreCalculationData(operand1, operand2, operation, result);

            return Ok("Calculation data stored successfully!");
        }
    }
}
