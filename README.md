# RichUnityPooling
System for managing GameObject pooling to improve Unity performance by reducing the frequency and amount of GameObject instantiation and destruction.

## Usage Tips
* Create a Layer named Poolers and hide that layer from cameras to hide any objects while they're pooled. The pool manager will automatically detect the Poolers layer.
