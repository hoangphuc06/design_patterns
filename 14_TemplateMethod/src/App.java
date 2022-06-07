public class App {
    public static void main(String[] args) throws Exception {
        CoffeeWithHook coffeeHook = new CoffeeWithHook();
        TeaWithHook teaHook = new TeaWithHook();
        System.out.println("\nMaking Tea... ");
        teaHook.prepareRecipe();
        System.out.println("\nMaking Coffee... ");
        coffeeHook.prepareRecipe();
    }
}
