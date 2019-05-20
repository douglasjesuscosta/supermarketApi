using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SupermarketAPI.Domain.Models;


namespace SupermarketAPI.Domain.Services.Communication {
    public class SaveCategoryResponse : BaseResponse {

        public Category Category { get; private set; }

        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message) {
            Category = category;
        }

        /// <summary>
        /// Creates a success response
        /// </summary>
        /// <param name="category">Saved category</param>
        /// <returns>Response.</returns>
        public SaveCategoryResponse(Category category) : this(true, string.Empty, category) {

        }

        /// <summary>
        /// Creates an error response
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveCategoryResponse(string message) : this(false, message, null) {

        }



    }
}
