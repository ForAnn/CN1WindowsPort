// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public abstract class _iSet {

} // end of abstract class: _iSet

public interface Set: global::java.util.Collection {
 bool add(global::java.lang.Object n1);

 bool addAll(global::java.util.Collection n1);

 void clear();

 bool contains(global::java.lang.Object n1);

 bool containsAll(global::java.util.Collection n1);

 bool equals(global::java.lang.Object n1);

 int hashCode();

 bool isEmpty();

 global::System.Object iterator();

 bool remove(global::java.lang.Object n1);

 bool removeAll(global::java.util.Collection n1);

 bool retainAll(global::java.util.Collection n1);

 int size();

 global::System.Object toArray();

 global::System.Object toArray(global::org.xmlvm._nArrayAdapter<global::System.Object> n1);

//XMLVM_BEGIN_WRAPPER[java.util.Set]
//XMLVM_END_WRAPPER[java.util.Set]

} // end of interface: Set

} // end of namespace: java.util
