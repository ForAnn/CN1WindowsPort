// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xml.sax {
public abstract class _iDocumentHandler {

} // end of abstract class: _iDocumentHandler

public interface DocumentHandler {
 void setDocumentLocator(global::org.xml.sax.Locator n1);

 void startDocument();

 void endDocument();

 void startElement(global::java.lang.String n1, global::org.xml.sax.AttributeList n2);

 void endElement(global::java.lang.String n1);

 void characters(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3);

 void ignorableWhitespace(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3);

 void processingInstruction(global::java.lang.String n1, global::java.lang.String n2);

//XMLVM_BEGIN_WRAPPER[org.xml.sax.DocumentHandler]
//XMLVM_END_WRAPPER[org.xml.sax.DocumentHandler]

} // end of interface: DocumentHandler

} // end of namespace: org.xml.sax
