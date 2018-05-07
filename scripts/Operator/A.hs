
newtype Bork = Bork Integer

instance Eq Bork where
    x == y = True

instance Num Bork where
    fromInteger = Bork

a :: Bork
a = 2 :: Bork 

main :: IO ()
main = print $ a == 1 && a == 2 && a == 3