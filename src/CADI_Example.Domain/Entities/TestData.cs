namespace CADI_Example.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Test Data Entity.
    /// </summary>
    public partial class TestData
    {
        /// <summary>
        /// Gets or sets AppSettingId.
        /// </summary>
        public long TestDataId { get; set; }

        /// <summary>
        /// Gets or sets TestType.
        /// </summary>
        public string TestType { get; set; }

        /// <summary>
        /// Gets or sets Value1.
        /// </summary>
        public string Value1 { get; set; }

        /// <summary>
        /// Gets or sets Value2.
        /// </summary>
        public string Value2 { get; set; }

        /// <summary>
        /// Gets or sets ExpectedValue.
        /// </summary>
        public string ExpectedValue { get; set; }

        /// <summary>
        /// Gets or sets TestResult.
        /// </summary>
        public string TestResult { get; set; }
    }
}
