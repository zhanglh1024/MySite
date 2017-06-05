
using System;
using System.Runtime.Serialization;
namespace Titan
{
    /// <summary>
    /// ���Ե�����
    /// </summary> 
    [DataContract]
    public class ConditionExpression : IConditionExpression
    {

        /// <summary>
        /// ���캯��
        /// </summary>
        public ConditionExpression()
        {

        }


        /// <summary>���캯��</summary>
        /// <param name="propertyName">��ʼ�������������ֶ�ȫ��</param>
        /// <param name="conditionOperator">��ʼ��������������</param>
        /// <param name="conditionValue">��ʼ������������ֵ</param>
        public ConditionExpression(string propertyName, ConditionOperator conditionOperator, object conditionValue)
        {
            Property = new PropertyExpression(propertyName);
            ConditionOperator = conditionOperator;
            ConditionValue = conditionValue;
        }

        /// <summary>���캯��</summary>
        /// <param name="propertyName">��ʼ�������������ֶ�ȫ��</param>
        /// <param name="groupFunction"></param>
        /// <param name="conditionOperator">��ʼ��������������</param>
        /// <param name="conditionValue">��ʼ������������ֵ</param>
        public ConditionExpression(string propertyName,GroupFunction groupFunction, ConditionOperator conditionOperator, object conditionValue)
        {
            Property = new PropertyExpression(propertyName, groupFunction);
            ConditionOperator = conditionOperator;
            ConditionValue = conditionValue;
        }


        #region ����



        /// <summary>
        /// ��ȡ������һ��ֵ����ֵָ��������������������
        /// </summary> 
        [DataMember]
        public PropertyExpression Property { get; set; }



        /// <summary>
        /// ��ȡ������һ��ֵ����ֵָ��������������
        /// </summary> 
        [DataMember]
        public ConditionOperator ConditionOperator { get; set; }

         

        /// <summary>
        /// ��ȡ������һ��ֵ����ֵָ������������ֵ
        /// </summary> 
        [DataMember]
        public object ConditionValue { get; set; }






        #endregion


        public void Not()
        {
            switch (ConditionOperator)
            {
                case ConditionOperator.Custom:
                    throw new InvalidOperationException("���������ΪCustomer�Ĳ�֧��Not����");
                case ConditionOperator.Equal:
                    ConditionOperator = ConditionOperator.NotEqual;
                    break;
                case ConditionOperator.FullTextLike:
                    ConditionOperator = ConditionOperator.NotFullTextLike;
                    break;
                case ConditionOperator.NotFullTextLike:
                    ConditionOperator = ConditionOperator.FullTextLike;
                    break;
                case ConditionOperator.GreaterThanOrEqual:
                    ConditionOperator = ConditionOperator.LessThan;
                    break;
                case ConditionOperator.GreaterThan:
                    ConditionOperator = ConditionOperator.LessThanOrEqual;
                    break;
                case ConditionOperator.In:
                    ConditionOperator = ConditionOperator.NotIn;
                    break;
                case ConditionOperator.LeftLike:
                    ConditionOperator = ConditionOperator.NotLeftLike;
                    break;
                case ConditionOperator.LessThanOrEqual:
                    ConditionOperator = ConditionOperator.GreaterThan;
                    break;
                case ConditionOperator.LessThan:
                    ConditionOperator = ConditionOperator.GreaterThanOrEqual;
                    break;
                case ConditionOperator.Like:
                    ConditionOperator = ConditionOperator.NotLike;
                    break;
                case ConditionOperator.NotEqual:
                    ConditionOperator = ConditionOperator.Equal;
                    break;
                case ConditionOperator.NotIn:
                    ConditionOperator = ConditionOperator.In;
                    break;
                case ConditionOperator.NotLeftLike:
                    ConditionOperator = ConditionOperator.LeftLike;
                    break;
                case ConditionOperator.NotRightLike:
                    ConditionOperator = ConditionOperator.RightLike;
                    break;
                case ConditionOperator.RightLike:
                    ConditionOperator = ConditionOperator.NotRightLike;
                    break;
            }
        }

        public ICondition And(ICondition conditionExpression)
        {

            ConditionExpressionCollection cs = new ConditionExpressionCollection();
            cs.ConditionRelation = ConditionRelation.And;
            cs.Add(this);
            if (conditionExpression is IConditionExpression)
            {
                cs.Add(conditionExpression);
            }
            else
            {
                IConditionExpressionCollection conditionCollection = (IConditionExpressionCollection)conditionExpression;
                if (conditionCollection.ConditionRelation == ConditionRelation.And)
                {
                    foreach (ICondition item in conditionCollection)
                    {
                        cs.Add(item);
                    }
                }
                else
                {
                    cs.Add(conditionCollection);
                }
            }
            return cs;
        }
        public ICondition Or(ICondition conditionExpression)
        {

            ConditionExpressionCollection cs = new ConditionExpressionCollection();
            cs.ConditionRelation = ConditionRelation.Or;
            cs.Add(this);
            if (conditionExpression is IConditionExpression)
            {
                cs.Add(conditionExpression);
            }
            else
            {
                IConditionExpressionCollection conditionCollection = (IConditionExpressionCollection)conditionExpression;
                if (conditionCollection.ConditionRelation == ConditionRelation.Or)
                {
                    foreach (ICondition item in conditionCollection)
                    {
                        cs.Add(item);
                    }
                }
                else
                {
                    cs.Add(conditionCollection);
                }
            }
            return cs;
        }

        #region overload operator
        public static ICondition operator &(ConditionExpression conditionItem, ICondition value)
        {
            return conditionItem.And(value);
        }
        public static ICondition operator |(ConditionExpression conditionItem, ICondition value)
        {
            return conditionItem.Or(value);
        }
        #endregion


        #region ��ʽ�ӿ�
        IPropertyExpression IConditionExpression.Property
        {
            get
            {
                return Property;
            }
            set
            {
                Property = (PropertyExpression)value;
            }
        }
        #endregion
    }

}