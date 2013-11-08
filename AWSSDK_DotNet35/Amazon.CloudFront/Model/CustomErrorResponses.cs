/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A complex type that contains zero or more CustomErrorResponse elements. </para>
    /// </summary>
    public class CustomErrorResponses
    {
        
        private int? quantity;
        private List<CustomErrorResponse> items = new List<CustomErrorResponse>();

        /// <summary>
        /// The number of custom error responses for this distribution.
        ///  
        /// </summary>
        public int Quantity
        {
            get { return this.quantity ?? default(int); }
            set { this.quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this.quantity.HasValue;
        }

        /// <summary>
        /// Optional: A complex type that contains custom error responses for this distribution. If Quantity is 0, you can omit Items.
        ///  
        /// </summary>
        public List<CustomErrorResponse> Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this.items.Count > 0;
        }
    }
}
