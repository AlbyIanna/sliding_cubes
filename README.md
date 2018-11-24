# Sliding Cubes
Cubes crashing into each other. Awesome!

This is a Unity begginner project to get started with simple stuff like components, physics, scripts and stuff.

This project is based on a [video tutorial series](https://www.youtube.com/playlist?list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6) found on youtube on the [Brackeys channel](https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA).

### Rigidbody
You want an object to use physics? Add the Rigidbody component.
You can take the Rigidbody component in the script to modify it, add forces and stuff:
```c#
public Rigidbody rb;
...
rb.useGravity = false;
rb.AddForce(0, 200, 500);
```

### FixedUpdate()
If you want to apply physics stuff in a script, it's better to use `FixedUpdate()` instaead of `Update()`.
To add forces, you should multiply values per `Time.deltaTime`, so that the forces won't be added every frame.
```c#
    rb.AddForce(0, 0, 500 * Time.deltaTime);
```

### Make the camera follow the character
```c#
public Transform playerTransform;
public Vector3 offset = new Vector3(0, 1, -5);

void Update () {
    transform.position = playerTransform.position + offset;
}
```

### Find an object in the scene
Want to find the instance of an object in the scene? Call `FindObjectOfType<ObjectType>()` passing the Object type in the angle brakets.
```
    FindObjectOfType<GameManager>().EndGame();
```