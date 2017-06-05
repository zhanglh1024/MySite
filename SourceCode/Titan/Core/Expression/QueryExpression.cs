using System.Runtime.Serialization;

namespace Titan
{
    /// <summary>
    /// �����������
    /// </summary> 
    [DataContract]
    [KnownType(typeof(OutputExpressionCollection))]
    [KnownType(typeof(ConditionExpressionCollection))]
    [KnownType(typeof(OrderExpressionCollection))]
    public class QueryExpression : IQueryExpression
    {
        #region ����
        /// <summary>
        /// �ݲ�֧��EntityType����
        /// </summary>
        [DataMember]
        public object EntityType { get; set; }


        /// <summary>
        /// �Ƿ�ȥ��
        /// </summary>
        [DataMember]
        public bool IsDistinct { get; set; }

        /// <summary>
        /// ÿҳ���ټ�¼��PageSize��PageIndexֻҪ��һ��Ϊnull���򷵻����м�¼
        /// </summary> 
        [DataMember]
        public int? PageSize { get; set; }

        /// <summary>
        /// �ڼ�ҳ��ʼ����1��ʼ������PageSize��PageIndexֻҪ��һ��Ϊnull���򷵻����м�¼
        /// </summary> 
        [DataMember]
        public int? PageIndex { get; set; }

        /// <summary>
        /// �Ƿ������������ļ�¼��
        /// </summary> 
        [DataMember]
        public bool ReturnMatchedCount { get; set; }



        private OutputExpressionCollection selects = new OutputExpressionCollection();
        /// <summary>
        /// ��������Լ���
        /// </summary> 
        [DataMember]
        public OutputExpressionCollection Selects
        {
            get
            {
                return selects;
            }
            set
            {
                selects = value;
            }
        }



        private ConditionExpressionCollection wheres = new ConditionExpressionCollection();
        /// <summary>
        /// ������������
        /// </summary> 
        [DataMember]
        public ConditionExpressionCollection Wheres
        {
            get
            {
                return wheres;
            }
            set
            {
                wheres = value;
            }
        }




        private OrderExpressionCollection orderBys = new OrderExpressionCollection();
        /// <summary>
        /// �������Եļ���
        /// </summary>  
        [DataMember]
        public OrderExpressionCollection OrderBys
        {
            get
            {
                return orderBys;
            }
            set
            {
                orderBys = value;
            }
        }



        private GroupExpressionCollection groupBys = new GroupExpressionCollection();
        /// <summary>
        /// ��������Լ���
        /// </summary> 
        [DataMember]
        public GroupExpressionCollection GroupBys
        {
            get
            {
                return groupBys;
            }
            set
            {
                groupBys = value;
            }
        }


        private ConditionExpressionCollection havings = new ConditionExpressionCollection();
        /// <summary>
        /// ������������
        /// </summary> 
        [DataMember]
        public ConditionExpressionCollection Havings
        {
            get
            {
                return havings;
            }
            set
            {
                havings = value;
            }
        }

        #endregion



        #region ���ٴ���
        public QueryExpression Select(params object[] propertys)
        {
            Selects.Add(propertys);
            return this;
        } 
        public QueryExpression OrderBy(params IOrderExpression[] orderExpressions)
        {
            foreach (IOrderExpression orderExpression in orderExpressions)
            {
                OrderBys.Add(orderExpression);
            }
            return this;
        }
        public QueryExpression Where(ICondition conditionExpression)
        {
            wheres.Add(conditionExpression);
            return this;
        }
        public QueryExpression Having(ICondition conditionExpression)
        {
            havings.Add(conditionExpression);
            return this;
        }
        public QueryExpression GroupBy(params IPropertyExpression[] propertys)
        {
            foreach (IPropertyExpression property in propertys)
            {
                GroupBys.Add(new GroupExpression(property.PropertyName));
            }
            return this;
        }
        public QueryExpression GroupBy(params string[] propertyNames)
        {
            foreach (string propertyName in propertyNames)
            {
                GroupBys.Add(propertyName);
            }
            return this;
        }
        #endregion



        #region ��ʽ�ӿ�
        IOutputExpressionCollection IQueryExpression.Selects
        {
            get
            {
                return selects;
            }
            set
            {
                selects = (OutputExpressionCollection)value;
            }
        }
        IConditionExpressionCollection IQueryExpression.Wheres
        {
            get
            {
                return wheres;
            }
            set
            {
                wheres = (ConditionExpressionCollection)value;
            }
        }

        IOrderExpressionCollection IQueryExpression.OrderBys
        {
            get
            {
                return orderBys;
            }
            set
            {
                orderBys = (OrderExpressionCollection)value;
            }
        }


        IGroupExpressionCollection IQueryExpression.GroupBys
        {
            get
            {
                return groupBys;
            }
            set
            {
                groupBys = (GroupExpressionCollection)value;
            }
        }

        IConditionExpressionCollection IQueryExpression.Havings
        {
            get
            {
                return havings;
            }
            set
            {
                havings = (ConditionExpressionCollection)value;
            }
        }
        #endregion

    }
}
