using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeService
{
    // http://localhost:8080/?xsd=xsd2

    #region No decoration
    //public class Employee
    //{
    //    public Int32 Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Gender { get; set; }
    //    public DateTime DateOfBirth { get; set; }
    //}
    // all public properties are automatically serialized
    // schema
    //<xs:element minOccurs = "0" name="DateOfBirth" type="xs:dateTime"/>
    //<xs:element minOccurs = "0" name="FirstName" nillable="true" type="xs:string"/>
    //<xs:element minOccurs = "0" name="Gender" nillable="true" type="xs:string"/>
    //<xs:element minOccurs = "0" name="Id" type="xs:int"/>
    //<xs:element minOccurs = "0" name="LastName" nillable="true" type="xs:string"/>
    #endregion

    #region With DataContract and DataMember
    // You can change the default namesapce by adding the Namespace attribute
    //[DataContract(Namespace = "http://ricadmintech.com/2026/03/30/Employee")]

    [DataContract]
    public class Employee
    {
        //[DataMember(Name = "ID", Order = 1)]
        [DataMember]
        public Int32 Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
    }
    // You can choose which fields will be serialized by 
    // decorating the class with [DataContract]
    // and decorating the fields or properties that you want to be included with [DataMember]
    // private fields and properties will also be serialized
    // Adding the [DataContract] and [DataMember] is the recommended approach
    // schema
    //<xs:element minOccurs = "0" name="DateOfBirth" type="xs:dateTime"/>
    //<xs:element minOccurs = "0" name="FirstName" nillable="true" type="xs:string"/>
    //<xs:element minOccurs = "0" name="Gender" nillable="true" type="xs:string"/>
    //<xs:element minOccurs = "0" name="Id" type="xs:int"/>
    //<xs:element minOccurs = "0" name="LastName" nillable="true" type="xs:string"/>
    #endregion
}
