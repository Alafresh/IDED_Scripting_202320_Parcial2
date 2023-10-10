# Descripción del Código

El código proporcionado es un conjunto de pruebas unitarias escritas en el marco de pruebas NUnit para verificar el funcionamiento correcto de una aplicación que simula un juego de rol. Estas pruebas se centran en crear personajes, equipamiento y habilidades para el juego, utilizando conceptos y técnicas de programación orientada a objetos (POO) como interfaces, clases abstractas, encapsulamiento, herencia y polimorfismo. Además, sigue el enfoque de desarrollo dirigido por pruebas (TDD).

## Clases y Estructuras Principales

### `Character` (Clase Abstracta)
- Esta clase abstracta representa la base para todos los personajes jugables y enemigos en el juego.
- Contiene propiedades como `Name`, `Weapon`, `Armor`, `Accessories`, `Moves`, `Attack`, `Defense`, `Skill`, y `Speed`.
- El constructor de esta clase inicializa las propiedades básicas de un personaje y aplica modificadores de ataque, defensa, habilidad y velocidad según el equipamiento y accesorios equipados.

### `PlayableCharacter` (Clase)
- Esta clase hereda de `Character` y representa a los personajes jugables en el juego.
- Su constructor específico verifica y asigna el tipo de habilidad permitida para el personaje (Magic, Technique, o Trick) según su clase.

### `EnemyCharacter` (Clase)
- Esta clase hereda de `Character` y representa a los enemigos en el juego.

### `Gear` (Clase Abstracta)
- Esta clase abstracta representa el equipamiento utilizado en el juego.
- Contiene propiedades para modificar atributos como ataque, defensa, habilidad y velocidad.

### `Weapon`, `Armor` y `Accessory` (Clases)
- Estas clases heredan de `Gear` y representan diferentes tipos de equipamiento en el juego.
- Cada clase tiene su propio constructor que aplica restricciones específicas y modifica los atributos según el tipo de equipamiento.

### `ICharacter` (Interfaz)
- Esta interfaz define las propiedades que deben implementar las clases de personajes, como su nombre, habilidades disponibles (Magic, Technique, Trick), y su capacidad para usar esas habilidades.

### Clase `Move`
- Representa una habilidad que un personaje puede usar.
- Contiene propiedades como `Name`, `Power` y `Type` (Magic, Technique o Trick).

## Pruebas Unitarias

Las pruebas unitarias utilizan el marco de pruebas NUnit para verificar el funcionamiento correcto de las clases y métodos en el código. Aquí hay algunas de las pruebas realizadas:

1. `CreateCharacters_WarriorCharacter_CreatesValidCharacter`
   - Prueba que un personaje Guerrero se cree correctamente con equipamiento y habilidades válidos.
   
2. `CreateCharacters_MageCharacter_CreatesValidCharacter`
   - Prueba que un personaje Mago se cree correctamente con equipamiento y habilidades válidos.

3. `CreateCharacters_ThiefCharacter_CreatesValidCharacter`
   - Prueba que un personaje Ladrón se cree correctamente con equipamiento y habilidades válidos.

4. `CreateCharacters_MonsterCharacter_CreatesValidCharacter`
   - Prueba que un personaje Monstruo se cree correctamente con equipamiento y atributos válidos.

5. `CreateWeapon_ValidModifiers_CreatesValidWeapon`
   - Prueba que se cree un arma con modificadores de ataque y habilidad válidos.

6. `CreateArmor_ValidModifiers_CreatesValidArmor`
   - Prueba que se cree una armadura con modificadores de defensa y velocidad válidos.

7. `CreateAccessory_ValidModifiers_CreatesValidAccessory`
   - Prueba que se cree un accesorio con modificadores válidos.

8. `AssignMoves_WarriorCharacter_ValidMove`
   - Prueba que un Guerrero pueda asignar una habilidad de tipo Technique correctamente.
