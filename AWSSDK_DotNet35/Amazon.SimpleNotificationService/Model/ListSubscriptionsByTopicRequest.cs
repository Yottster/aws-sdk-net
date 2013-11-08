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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the ListSubscriptionsByTopic operation.
    /// <para>The <c>ListSubscriptionsByTopic</c> action returns a list of the subscriptions to a specific topic. Each call returns a limited list
    /// of subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a
    /// new <c>ListSubscriptionsByTopic</c> call to get further results.</para>
    /// </summary>
    public partial class ListSubscriptionsByTopicRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        private string nextToken;
        /// <summary>
        /// Default constructor for a new ListSubscriptionsByTopicRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public ListSubscriptionsByTopicRequest() {}
    
        /// <summary>
        /// Constructs a new ListSubscriptionsByTopicRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic for which you wish to find subscriptions. </param>
        public ListSubscriptionsByTopicRequest(string topicArn)
        {
            this.topicArn = topicArn;
        }
    
        /// <summary>
        /// Constructs a new ListSubscriptionsByTopicRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic for which you wish to find subscriptions. </param>
        /// <param name="nextToken"> Token returned by the previous <c>ListSubscriptionsByTopic</c> request. </param>
        public ListSubscriptionsByTopicRequest(string topicArn, string nextToken)
        {
            this.topicArn = topicArn;
            this.nextToken = nextToken;
        }
    

        /// <summary>
        /// The ARN of the topic for which you wish to find subscriptions.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }

        /// <summary>
        /// Token returned by the previous <c>ListSubscriptionsByTopic</c> request.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

    }
}
    
