# SequenceDiagramCSharp
A library designed to generate sequence diagrams using PlantUML sequence diagram scripting syntax. Given the path to a Visual Studio solution, the library will analyze a given entry point method in the specified class, and it will generate a diagram showing all of the method calls invoked from within the provided method. It shows the return type as well. Any variables declared that have subsequent method invocations performed against them will have their declarations displayed on the diagram. Also represented on the diagrams are if / else if / else clauses, for / foreach clauses, while and do while clauses