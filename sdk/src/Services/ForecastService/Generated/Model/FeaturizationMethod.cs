/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides information about a method that featurizes (transforms) a dataset field.
    /// The method is part of the <code>FeaturizationPipeline</code> of the <a>Featurization</a>
    /// object. If <code>FeaturizationMethodParameters</code> isn't specified, Amazon Forecast
    /// uses default parameters.
    /// 
    ///  
    /// <para>
    /// For example:
    /// </para>
    ///  
    /// <para>
    ///  <code>{</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"FeaturizationMethodName": "filling",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"FeaturizationMethodParameters": {"aggregation": "avg", "backfill": "nan"}</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code>}</code> 
    /// </para>
    /// </summary>
    public partial class FeaturizationMethod
    {
        private FeaturizationMethodName _featurizationMethodName;
        private Dictionary<string, string> _featurizationMethodParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property FeaturizationMethodName. 
        /// <para>
        /// The name of the method. In this release, "filling" is the only supported method.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeaturizationMethodName FeaturizationMethodName
        {
            get { return this._featurizationMethodName; }
            set { this._featurizationMethodName = value; }
        }

        // Check to see if FeaturizationMethodName property is set
        internal bool IsSetFeaturizationMethodName()
        {
            return this._featurizationMethodName != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturizationMethodParameters. 
        /// <para>
        /// The method parameters (key-value pairs). Specify these to override the default values.
        /// The following list shows the parameters and their valid values. Bold signifies the
        /// default value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>aggregation</code>: <b>sum</b>, <code>avg</code>, <code>first</code>, <code>min</code>,
        /// <code>max</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>frontfill</code>: <b>none</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>middlefill</code>: <b>zero</b>, <code>nan</code> (not a number)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>backfill</code>: <b>zero</b>, <code>nan</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public Dictionary<string, string> FeaturizationMethodParameters
        {
            get { return this._featurizationMethodParameters; }
            set { this._featurizationMethodParameters = value; }
        }

        // Check to see if FeaturizationMethodParameters property is set
        internal bool IsSetFeaturizationMethodParameters()
        {
            return this._featurizationMethodParameters != null && this._featurizationMethodParameters.Count > 0; 
        }

    }
}