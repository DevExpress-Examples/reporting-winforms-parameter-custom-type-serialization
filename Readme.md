<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603236/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3186)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))**
<!-- default file list end -->
# How to serialize parameters of custom types


<p>This example demonstrates the capability to provide XML serialization of custom parameter types.</p><p>In particular, it shows how you can save a report, along with its parameters of the <strong>System.Enum</strong> type, to XML file.</p><p>To do this, override the <strong>ReportStorageExtension</strong> class, and register a custom <strong>ReportDesignExtension</strong>, which implements the data source serialization functionality.</p><p>To serialize custom objects and properties, specify the <strong>XtraSerializ</strong><strong>ableProperty</strong> attribute with the <strong>XtraSerializationVisibility.Reference</strong> parameter (this parameter defines whether or not an object should be serialized by a reference).</p>

<br/>


