

using System.Runtime.Serialization;
namespace Titan
{
    /// <summary>
    /// 
    /// </summary> 
    [DataContract]
    public class OrderExpression : IOrderExpression
    {
        #region ���캯��
        /// <summary>
        /// ���캯��
        /// </summary>
        public OrderExpression()
        {
            OrderType = OrderType.Asc;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="propertyName">������Ե�����</param>
        /// <param name="orderType">��������</param>
        public OrderExpression(string propertyName, OrderType orderType)
        {
            Property = new PropertyExpression(propertyName);
            OrderType = orderType;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="propertyName">������Ե�����</param>
        /// <param name="groupFunction"></param>
        /// <param name="orderType">��������</param>
        public OrderExpression(string propertyName,GroupFunction groupFunction, OrderType orderType)
        {
            Property = new PropertyExpression(propertyName, groupFunction);
            OrderType = orderType;
        }

        #endregion

        /// <summary>
        /// ��������Ե�����
        /// </summary> 
        [DataMember]
        public PropertyExpression Property { get; set; }



        /// <summary>
        /// �������ͣ�������߽���
        /// </summary> 
        [DataMember]
        public OrderType OrderType { get; set; }

         


        public override string ToString()
        {
            return Property + " " + OrderType.ToString();
        }

        IPropertyExpression IOrderExpression.Property
        {
            get
            {
                return Property;
            }
            set
            {
                Property=(PropertyExpression)value;
            }
        }
    }




}
