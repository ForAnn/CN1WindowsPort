// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom {
public class DomXPathNSResolver: global::java.lang.Object,global::org.w3c.dom.xpath.XPathNSResolver {
public global::org.w3c.dom.Node _fnode;

public void @this(global::org.w3c.dom.Node n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomXPathNSResolver: void <init>(org.w3c.dom.Node)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::gnu.xml.dom.DomXPathNSResolver) _r0_o)._fnode = (global::org.w3c.dom.Node) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomXPathNSResolver: void <init>(org.w3c.dom.Node)]
}

public virtual global::System.Object lookupNamespaceURI(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomXPathNSResolver: java.lang.String lookupNamespaceURI(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.dom.DomXPathNSResolver) _r1_o)._fnode;
    _r0_o = ((global::org.w3c.dom.Node) _r0_o).lookupNamespaceURI((global::java.lang.String) _r2_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.DomXPathNSResolver: java.lang.String lookupNamespaceURI(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.DomXPathNSResolver]
//XMLVM_END_WRAPPER[gnu.xml.dom.DomXPathNSResolver]

} // end of class: DomXPathNSResolver

} // end of namespace: gnu.xml.dom
