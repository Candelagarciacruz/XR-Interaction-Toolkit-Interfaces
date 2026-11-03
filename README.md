# XR-Interaction-Toolkit-Interfaces

## Descripción

Esta práctica se ha realizado en Unity utilizando **XR Interaction Toolkit** para trabajar con interacciones en realidad virtual, ya que **Meta XR SDK** estaba dando problemas.

Se ha configurado una escena XR y utilizado diferentes tipos de interacción con objetos.

## Configuración de la escena

Se ha utilizado una escena de demostración como base, conservando los elementos principales necesarios para la experiencia XR:

- XR Origin (XR Rig).
- Main Camera.
- XR Interaction Manager.
- EventSystem.
- Controladores izquierdo y derecho.
- Near-Far Interactor en ambos controladores.

## Interacciones realizadas

### 1. Cambio de color del cubo y de la esfera

Se ha configurado el cubo y la esfera para modificar su color al interactuar con él:

- Cambio de color a rosa al seleccionar el objeto utilizando el click izquierdo.
- Vuelta a su color inicial al dejar de seleccionarlo.

La configuración se ha realizado mediante **Interactable Events desde el Inspector de Unity en el componente XR Simple Interactable** en ambos objetos se ha realizado lo mismo:

<img width="461" height="505" alt="image" src="https://github.com/user-attachments/assets/6aff2cad-1a3d-4f5f-a5b6-b667e740c63f" />

### 3. Agarrar un objeto del Asset Store

Se ha incorporado un objeto descargado desde Unity Asset Store, una seta marrón, y se han configurado los componentes necesarios para permitir su manipulación en realidad virtual:

- Rigidbody.
- Collider.
- XR Grab Interactable.

De esta manera, los controladores pueden agarrar, mover y soltar el objeto.
Para mostrar el texto se ha creado un UI Canvas y para su actualización se ha creado un script. Además se ha vuelto ha configurar **Interactable Events desde el Inspector de Unity esta vez en el componente XR Grab Interactable** para llamar a la función creada en dicho script: 

<img width="211" height="196" alt="image" src="https://github.com/user-attachments/assets/bb26a2ce-5cd8-4841-a220-f6d72d1eb879" />

## Tecnologías utilizadas

- Unity.
- XR Interaction Toolkit.
- Meta XR SDK.
- Unity Asset Store.

## Resultado

Se ha conseguido configurar una escena de realidad virtual con interacciones de apuntado, selección y agarre de objetos, utilizando los eventos del Inspector y los componentes de XR Interaction Toolkit. A continuación se muestra su resultado al ejcutar:

<img width="1894" height="856" alt="interaction" src="https://github.com/user-attachments/assets/f28b786c-d988-4fee-b381-e7e4d0669081" />
