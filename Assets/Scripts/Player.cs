using UnityEngine;
using System.Collections;


public class Player : MonoBehaviour
{
    // configuration parameters, consdier SO
    [Header("Projectile")]
	[SerializeField] GameObject laserPrefab;
	[SerializeField] float projectileSpeed = 10;
	[SerializeField] float projectileFiringPeriod = 0.2f;
    [SerializeField] AudioClip fireSound;
	
    [Header("Player")]
	[SerializeField] float speed = 15.0f;
	[SerializeField] float padding = 1;
	[SerializeField] int health = 200;

    // cached references for readability

    // private instance variables for state
	float xmax = -5;
	float xmin = 5;
    float ymax = -5;
    float ymin = 5;

    Coroutine firingHandle;
	
    // messages, then public methods, then private methods...
    void OnTriggerEnter2D(Collider2D other)
    {
		var projectile = other.gameObject.GetComponent<Projectile>();
		if(!projectile) { return; }  //project against null
        ProcessHit(projectile);
    }

    private void ProcessHit(Projectile projectile)
    {
        health -= projectile.GetDamage();
        projectile.Hit();
        if (health <= 0)
        {
            Die();
        }
    }

    public int GetCurrentHealth()
    {
        return health;
    }

    void Start()
    {
        SetUpPlaySpace();
    }

    private void SetUpPlaySpace()
    {
        Camera mainCamera = Camera.main;
        //float distance = transform.position.z - mainCamera.transform.position.z;
        xmin = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 1)).x + padding;
        xmax = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 1)).x - padding;
        ymin = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 1)).y + padding;
        ymax = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 1)).y - padding;
    }

    void Update ()
    {
        Fire();
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var deltaY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xmin, xmax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, ymin, ymax);
        transform.position = new Vector2(newXPos, newYPos);
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))  // Only start coroutine once
        {
            firingHandle = StartCoroutine(FireContinuously());
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(firingHandle);
        }
    }

    IEnumerator FireContinuously()
    {
        while(true)  // forever so we must stop the co-routine
        {
            GameObject laser = Instantiate(
                laserPrefab,
                transform.position,
                Quaternion.identity,
                Level.GetSpawnParent()
            ) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector3(0, projectileSpeed, 0);
            AudioSource.PlayClipAtPoint(fireSound, transform.position); // implicit instantiate, not easy to parent
            yield return new WaitForSeconds(projectileFiringPeriod);
        }
    }

    private void Die()
    {
        Level level = FindObjectOfType<Level>();
        level.LoadNextScene();
        Destroy(gameObject);
    }
}
