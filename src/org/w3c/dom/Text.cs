// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.w3c.dom {
public abstract class _iText {

} // end of abstract class: _iText

public interface Text: global::org.w3c.dom.CharacterData {
 global::System.Object splitText(int n1);

 bool isElementContentWhitespace();

 global::System.Object getWholeText();

 global::System.Object replaceWholeText(global::java.lang.String n1);

 global::System.Object appendChild(global::org.w3c.dom.Node n1);

 void appendData(global::java.lang.String n1);

 global::System.Object cloneNode(bool n1);

 short compareDocumentPosition(global::org.w3c.dom.Node n1);

 void deleteData(int n1, int n2);

 global::System.Object getAttributes();

 global::System.Object getBaseURI();

 global::System.Object getChildNodes();

 global::System.Object getData();

 global::System.Object getFeature(global::java.lang.String n1, global::java.lang.String n2);

 global::System.Object getFirstChild();

 global::System.Object getLastChild();

 int getLength();

 global::System.Object getLocalName();

 global::System.Object getNamespaceURI();

 global::System.Object getNextSibling();

 global::System.Object getNodeName();

 short getNodeType();

 global::System.Object getNodeValue();

 global::System.Object getOwnerDocument();

 global::System.Object getParentNode();

 global::System.Object getPrefix();

 global::System.Object getPreviousSibling();

 global::System.Object getTextContent();

 global::System.Object getUserData(global::java.lang.String n1);

 bool hasAttributes();

 bool hasChildNodes();

 global::System.Object insertBefore(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2);

 void insertData(int n1, global::java.lang.String n2);

 bool isDefaultNamespace(global::java.lang.String n1);

 bool isEqualNode(global::org.w3c.dom.Node n1);

 bool isSameNode(global::org.w3c.dom.Node n1);

 bool isSupported(global::java.lang.String n1, global::java.lang.String n2);

 global::System.Object lookupNamespaceURI(global::java.lang.String n1);

 global::System.Object lookupPrefix(global::java.lang.String n1);

 void normalize();

 global::System.Object removeChild(global::org.w3c.dom.Node n1);

 global::System.Object replaceChild(global::org.w3c.dom.Node n1, global::org.w3c.dom.Node n2);

 void replaceData(int n1, int n2, global::java.lang.String n3);

 void setData(global::java.lang.String n1);

 void setNodeValue(global::java.lang.String n1);

 void setPrefix(global::java.lang.String n1);

 void setTextContent(global::java.lang.String n1);

 global::System.Object setUserData(global::java.lang.String n1, global::java.lang.Object n2, global::org.w3c.dom.UserDataHandler n3);

 global::System.Object substringData(int n1, int n2);

//XMLVM_BEGIN_WRAPPER[org.w3c.dom.Text]
//XMLVM_END_WRAPPER[org.w3c.dom.Text]

} // end of interface: Text

} // end of namespace: org.w3c.dom
