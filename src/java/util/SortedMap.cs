// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public abstract class _iSortedMap {

} // end of abstract class: _iSortedMap

public interface SortedMap: global::java.util.Map {
 global::System.Object comparator();

 global::System.Object firstKey();

 global::System.Object headMap(global::java.lang.Object n1);

 global::System.Object lastKey();

 global::System.Object subMap(global::java.lang.Object n1, global::java.lang.Object n2);

 global::System.Object tailMap(global::java.lang.Object n1);

new  void clear();

new  bool containsKey(global::java.lang.Object n1);

new  bool containsValue(global::java.lang.Object n1);

new  global::System.Object entrySet();

new  bool equals(global::java.lang.Object n1);

new  global::System.Object get(global::java.lang.Object n1);

new  int hashCode();

new  bool isEmpty();

new  global::System.Object keySet();

new  void putAll(global::java.util.Map n1);

new  global::System.Object put(global::java.lang.Object n1, global::java.lang.Object n2);

new  global::System.Object remove(global::java.lang.Object n1);

new  int size();

new  global::System.Object values();

//XMLVM_BEGIN_WRAPPER[java.util.SortedMap]
//XMLVM_END_WRAPPER[java.util.SortedMap]

} // end of interface: SortedMap

} // end of namespace: java.util
