using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppTest.Models
{
    public class Product
    {
        /// <summary>  
        /// Gets or sets the id.  
        /// </summary>  
        /// <value>The id.</value>  
        [Key]
        public int ProductId { get; set; }

        /// <summary>  
        /// 直接做型号处理  
        /// </summary>  
        public string ProductName { get; set; }
        /// <summary>  
        /// Gets or sets the category.  
        /// </summary>  
        /// <value>The category.</value>  
        public string Category { get; set; }

        /// <summary>  
        /// Gets or sets the brand.  
        /// </summary>  
        /// <value>The brand.</value>  
        public string Brand { get; set; }

        public string Size { get; set; }

        /// <summary>  
        /// Gets or sets the 规格.  
        /// </summary>  
        /// <value>The standard.</value>  
        public string Standard { get; set; }

        /// <summary>  
        /// 专柜  
        /// </summary>  
        public decimal ZhuanGui { get; set; }

        /// <summary>  
        /// Gets or sets the 莎莎 price.  
        /// </summary>  
        /// <value>The sa sa price.</value>  
        public decimal SaSaPrice { get; set; }

        /// <summary>  
        /// Gets or sets the 卓越 price.  
        /// </summary>  
        /// <value>The zhuoyue price.</value>  
        public decimal ZhuoyuePrice { get; set; }
        /// <summary>  
        /// Gets or sets the 卡莱美 price.  
        /// </summary>  
        /// <value>The ka lai price.</value>  
        public decimal KaLaiPrice { get; set; }

        /// <summary>  
        /// 雅施  
        /// </summary>  
        public decimal YaShi { get; set; }

        /// <summary>  
        /// Gets or sets the 万宁 price.  
        /// </summary>  
        /// <value>The wanning price.</value>  
        public decimal WanningPrice { get; set; }
        /// <summary>  
        /// Gets or sets the 屈臣氏 price.  
        /// </summary>  
        /// <value>The quchengshi price.</value>  
        public decimal QuchengshiPrice { get; set; }
        /// <summary>  
        /// Gets or sets the 药店 price.  
        /// </summary>  
        /// <value>The drugstore price.</value>  
        public decimal DrugstorePrice { get; set; }

        /// <summary>  
        /// Gets or sets the others.  
        /// </summary>  
        /// <value>The others.</value>  
        public string Others { get; set; }

        /// <summary>  
        /// Gets or sets the create time.  
        /// </summary>  
        /// <value>The create time.</value>  
        public DateTime CreateTime { get; set; }

        public string ImgUrl { get; set; }

        public Product()
        {
            CreateTime = DateTime.Now;
        }
    }
}