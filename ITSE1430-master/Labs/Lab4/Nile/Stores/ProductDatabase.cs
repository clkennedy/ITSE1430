/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            if (product == null)
                throw new ArgumentNullException("product");

            ValidateProduct(product);

            //Emulate database by storing copy
            return AddCore(product);
        }

        private void ValidateProduct(Product product)
        {
            try
            {
                product.Validate(new ValidationContext(product));
            }
            catch (ValidationException e)
            {
                throw new ValidationException("Validation Failed", e);
            }
        }
        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            if (id < 0)
                throw new ArgumentException("Cannot Be less than 0", "id");

            return GetCore(id);
        }
        
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }
        
        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            if (id < 0)
                throw new ArgumentException("Cannot Be less than 0", "id");

            RemoveCore(id);
        }
        
        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( Product product )
        {
            if (product == null)
                throw new ArgumentNullException("product");

            if (GetAllCore().Where(p=> p == product).FirstOrDefault() == null)
                throw new ProductDoesNotExistException();

            ValidateProduct(product);

            //Get existing product
            var existing = GetCore(product.Id);

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );
        #endregion

        public class ProductDoesNotExistException : ArgumentException
        {
            public ProductDoesNotExistException() : base("Product does not exist in DataBase")
            {

            }
            
        }
    }
}
