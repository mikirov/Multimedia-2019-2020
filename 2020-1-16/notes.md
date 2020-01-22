# Test topics:

- finding a contour and many contours - definition, algorithm
- line rasterization - mid-point algorithm
- rendering process and it's subprocesses



# Rendering process

## 3D models

- primitives
- user defined

## rendering spaces

- local space
  - translating from local to global space
  - Transform = Scaling * Rotation * Translation
- global space
  - camera
    - a single point in space
    - it has a <b>view plane</b>
    - horizon - maximum distance at which it can capture light
    - the camera looks towards the local Z axis by convention
    - x and y are mapped accordingly. 
  - lights
    - diffused - <b>it has no direction !</b>   
    - specular (оптическа) - obeys optics rules of reflection
    - 3 main types:
      - omni - in all directions
      -  spot light - in a cone ( projector)
      - ambient light - uses the same light everywhere
  - textures
    - placing a 2D image on top of a 3D object using mapping
    - used to imitate a material
    - types of mapping:
      - using a map plane - planar mapping
      - spherical mapping - the object gets placed inside a sphere and texture is projected on top
      - cylindrical mapping the texture is placed on a cylinder and projected at the object
- camera space
  - the camera space is between the view plane and the horizon
  - central projection onto a plane using perspective
  - we go from global space to camera space by applying rotation and translation + perspective
  - back-face culling
- screen space
  - artificial transformation
  - rasterization of model surfaces; rendering single points
  - z buffer
  - shading algorithm (colorization)
    - ray tracing for shading
    - radiosity