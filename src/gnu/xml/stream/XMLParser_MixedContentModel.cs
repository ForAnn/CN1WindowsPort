// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.stream {
public class XMLParser_2MixedContentModel: global::gnu.xml.stream.XMLParser_2ContentModel {
private global::java.util.HashSet _fnames;

public global::gnu.xml.stream.XMLParser _fthis_20;

public void @this(global::gnu.xml.stream.XMLParser n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel: void <init>(gnu.xml.stream.XMLParser)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::gnu.xml.stream.XMLParser_2MixedContentModel) _r1_o)._fthis_20 = (global::gnu.xml.stream.XMLParser) _r2_o;
    _r0.i = 3;
    ((global::gnu.xml.stream.XMLParser_2ContentModel) _r1_o).@this((global::gnu.xml.stream.XMLParser) _r2_o, (int) _r0.i);
    _r0_o = new global::java.util.HashSet();
    ((global::java.util.HashSet) _r0_o).@this();
    ((global::gnu.xml.stream.XMLParser_2MixedContentModel) _r1_o)._fnames = (global::java.util.HashSet) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel: void <init>(gnu.xml.stream.XMLParser)]
}

public virtual void addName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel: void addName(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2MixedContentModel) _r1_o)._fnames;
    ((global::java.util.HashSet) _r0_o).add((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel: void addName(java.lang.String)]
}

public virtual bool containsName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel: boolean containsName(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::gnu.xml.stream.XMLParser_2MixedContentModel) _r1_o)._fnames;
    _r0.i = ((global::java.util.HashSet) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel: boolean containsName(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel]
//XMLVM_END_WRAPPER[gnu.xml.stream.XMLParser$MixedContentModel]

} // end of class: XMLParser_2MixedContentModel

} // end of namespace: gnu.xml.stream
