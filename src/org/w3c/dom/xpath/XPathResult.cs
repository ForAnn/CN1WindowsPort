// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom.xpath {
public abstract class _iXPathResult {
public static short _fANY_1TYPE = 0;

public static short _fNUMBER_1TYPE = 1;

public static short _fSTRING_1TYPE = 2;

public static short _fBOOLEAN_1TYPE = 3;

public static short _fUNORDERED_1NODE_1ITERATOR_1TYPE = 4;

public static short _fORDERED_1NODE_1ITERATOR_1TYPE = 5;

public static short _fUNORDERED_1NODE_1SNAPSHOT_1TYPE = 6;

public static short _fORDERED_1NODE_1SNAPSHOT_1TYPE = 7;

public static short _fANY_1UNORDERED_1NODE_1TYPE = 8;

public static short _fFIRST_1ORDERED_1NODE_1TYPE = 9;


} // end of abstract class: _iXPathResult

public interface XPathResult {
 short getResultType();

 double getNumberValue();

 global::System.Object getStringValue();

 bool getBooleanValue();

 global::System.Object getSingleNodeValue();

 bool getInvalidIteratorState();

 int getSnapshotLength();

 global::System.Object iterateNext();

 global::System.Object snapshotItem(int n1);

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.xpath.XPathResult]
//XMLVM_END_WRAPPER[org.w3c.dom.xpath.XPathResult]

} // end of interface: XPathResult

} // end of namespace: org.w3c.dom.xpath
