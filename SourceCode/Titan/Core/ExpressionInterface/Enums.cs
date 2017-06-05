 

namespace Titan
{
    
    /// <summary>
    /// ����ʽ�������ǽ���
    /// </summary>  
    public enum OrderType
    {
        /// <summary>����</summary> 
        Asc = 0,
        /// <summary>����</summary> 
        Desc = 1
    }


    /// <summary>�����</summary>
    /// <seealso>ConditionExpression
    ///   <cref>ConditionExpression</cref>
    /// </seealso>
    /// <example>������ʾ�� <c>MyMethod</c> is a method in the <c>MyClass</c>
    /// <code>
    /// asdasdf---
    /// asdasd
    /// <B><font color="#FF0000">ttt</font></B>
    ///     777
    /// yyy
    /// uuu
    /// </code>
    /// <list type="bullet">
    /// <item>
    /// <description>Item 1.</description>
    /// </item>
    /// <item>
    /// <description>Item 2.</description>
    /// </item>
    /// </list>
    /// </example> 
    public enum ConditionOperator
    {
        /// <summary>
        /// ����
        /// </summary> 
        GreaterThan = 1,


        /// <summary>
        /// С��
        /// </summary> 
        LessThan = 2,


        /// <summary>
        /// ����
        /// </summary> 
        Equal = 0,


        /// <summary>
        /// ���ڵ���
        /// </summary> 
        GreaterThanOrEqual = 3,


        /// <summary>
        /// С�ڵ���
        /// </summary> 
        LessThanOrEqual = 4,


        /// <summary>
        /// ������
        /// </summary> 
        NotEqual = 5,


        /// <summary>
        /// ���ƣ����Զ���ǰ����ӡ�%��
        /// </summary> 
        Like = 6,


        /// <summary>
        /// �����ƣ����Զ���ӡ�%��
        /// </summary> 
        NotLike = 7,


        /// <summary>
        /// ����
        /// </summary> 
        In = 8,


        /// <summary>
        /// ������
        /// </summary> 
        NotIn = 9,


        /// <summary>
        /// �����ƣ����Զ���β����ӡ�%��
        /// </summary> 
        LeftLike = 10,


        /// <summary>
        /// �������ƣ����Զ���β����ӡ�%��
        /// </summary> 
        NotLeftLike = 11,


        /// <summary>
        /// �����ƣ����Զ���ͷ����ӡ�%��
        /// </summary> 
        RightLike = 12,


        /// <summary>
        /// �������ƣ����Զ���ͷ����ӡ�%��
        /// </summary> 
        NotRightLike = 13,


        /// <summary>
        /// ȫ������like
        /// </summary>
        FullTextLike = 14,


        /// <summary>
        /// ȫ������not like
        /// </summary>
        NotFullTextLike = 15,


        /// <summary>
        /// �Զ��壬������ConditionField��FieldValue������ָ�������
        /// </summary> 
        Custom = 99
    }



    /// <summary>��������ϵ</summary> 
    public enum ConditionRelation
    {
        /// <summary>And</summary> 
        And = 0,
        /// <summary>Or</summary> 
        Or = 1
    }



    public enum GroupFunction
    {
        None = 0,
        Count = 1,
        Sum = 2,
        Avg = 3,
        Max = 4,
        Min = 5
    }
}
